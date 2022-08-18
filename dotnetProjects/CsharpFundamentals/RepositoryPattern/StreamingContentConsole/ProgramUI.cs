using StreamingContentRepository;

public class ProgramUI {
    private Repository _repo = new Repository();

    public void Run() {
        // Seed() is used to fill content into _contentDirectory before Menu is displayed
        Seed();
        Menu();
    }

    private void Menu() {
        bool keepRunning = true;

        while (keepRunning) {
            Console.Clear();

            System.Console.WriteLine("Please select from the following options:\n" 
                + "1. Create new content\n"
                + "2. View all content\n"
                + "3. View content by title\n"
                + "4. Update content by title\n"
                + "5. Delete content by title\n"
                + "6. Exit");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewContent();
                    break;
                case "2":
                    ViewAllContent();
                    break;
                case "3":
                    ViewContentByTitle();
                    break;
                case "4":
                    UpdateContentByTitle();
                    break;
                case "5":
                    System.Console.WriteLine("delete");
                    break;
                case "6":
                    System.Console.WriteLine("bye bye!");

                    keepRunning = false;
                    break;
                default:
                    System.Console.WriteLine("Read better and pick a number from one of the options dude.");
                    break;
            }

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    // create
    private void CreateNewContent() {
        Console.Clear();
        
        StreamingContent newContent = new StreamingContent();

        System.Console.WriteLine("Please enter a title for the new content...");
        newContent.Title = Console.ReadLine();

        System.Console.WriteLine("Please enter a description for the new content...");
        newContent.Description = Console.ReadLine();

        System.Console.WriteLine("Please enter a rating for the content between 0.0 - 5.0 ...");
        string ratingString = Console.ReadLine();
        newContent.StarRating = double.Parse(ratingString);

        System.Console.WriteLine("Please select a maturity rating for the content based on the following options:\n"
        + "1. G\n"
        + "2. PG\n"
        + "3. PG13\n"
        + "4. R\n"
        + "5. X\n"
        + "6. TVMA\n"
        + "7. NC17");
        string maturityString = Console.ReadLine();
        // converting string option selected to an integer
        int maturityInt = int.Parse(maturityString);
        // using type casting "()" before integer variable to convert integer to "MaturityRating" enum equivalent based on enum index
        newContent.MaturityRating = (MaturityRating)maturityInt;

        System.Console.WriteLine("Please select a genre for the content based on the following options:\n"
        + "1. SciFi\n"
        + "2. Documentary\n"
        + "3. Comedy\n"
        + "4. Horror\n"
        + "5. Action\n"
        + "6. Thriller\n"
        + "7. Western\n"
        + "8. RomCom");
        string genreString = Console.ReadLine();
        // converting string option selected to an integer
        int genreInt = int.Parse(genreString);
        // using type casting "()" before integer variable to convert integer to "GenreType" enum equivalent based on enum index
        newContent.TypeOfGenre = (GenreType)genreInt;

        bool addResult = _repo.AddContentToDirectory(newContent);

        if (addResult) {
            Console.Clear();
            System.Console.WriteLine("Content successfully added!");
        } else {
            Console.Clear();
            System.Console.WriteLine("there was an issue adding your content");
        }
    }
    
    // view all
    private void ViewAllContent() {
        Console.Clear();

        List<StreamingContent> contentList = _repo.GetAllContent();

        if (contentList.Count > 0) {
            foreach (StreamingContent content in contentList)
            {
                DisplayContent(content);
            }
        } else {
            System.Console.WriteLine("There is no content to be viewed at this time.");
        }
    }
    
    // view one
    private void ViewContentByTitle() {
        Console.Clear();

        System.Console.WriteLine("Please enter a title for the content you would like to view:");

        string title = Console.ReadLine();
        StreamingContent contentToView = _repo.GetContentByTitle(title);

        Console.Clear();
        if (contentToView != null) {
            DisplayContent(contentToView);
        } else {
            System.Console.WriteLine("there is no content with that title... try option 2 from the menu to see what you are able to view");
        }
    }
    // update
    private void UpdateContentByTitle() {
        Console.Clear();

        System.Console.WriteLine("Please enter a title for the content you would like to update:");

        string title = Console.ReadLine();
        StreamingContent contentToUpdate = _repo.GetContentByTitle(title);

        Console.Clear();
        if (contentToUpdate != null) {
            StreamingContent newContent = new StreamingContent();

            System.Console.WriteLine("Enter a new title for this content, if not press enter to continue...");
            newContent.Title = Console.ReadLine();

            System.Console.WriteLine("Enter a new description for this content, if not press enter to continue...");
            newContent.Description = Console.ReadLine();

            System.Console.WriteLine("Enter a new star rating between 0.0 - 5.0 for this content, if not press enter to continue...");
            string ratingString = Console.ReadLine();
            // ternary is checking if there was no input for "ratingString", if not it will default to 0
            newContent.StarRating = ratingString != "" ? double.Parse(ratingString) : 0;

            System.Console.WriteLine("Please select a new maturity rating for the content based on the following options, if not press enter:\n"
            + "1. G\n"
            + "2. PG\n"
            + "3. PG13\n"
            + "4. R\n"
            + "5. X\n"
            + "6. TVMA\n"
            + "7. NC17");
            string maturityString = Console.ReadLine();
            // converting string option selected to an integer
            int maturityInt = maturityString != "" ? int.Parse(maturityString) : 0;
            // using type casting "()" before integer variable to convert integer to "MaturityRating" enum equivalent based on enum index
            newContent.MaturityRating = (MaturityRating)maturityInt;

            System.Console.WriteLine("Please select a new genre for the content based on the following options, if not press enter:\n"
            + "1. SciFi\n"
            + "2. Documentary\n"
            + "3. Comedy\n"
            + "4. Horror\n"
            + "5. Action\n"
            + "6. Thriller\n"
            + "7. Western\n"
            + "8. RomCom");
            string genreString = Console.ReadLine();
            // converting string option selected to an integer
            int genreInt = genreString != "" ? int.Parse(genreString) : 0;
            // using type casting "()" before integer variable to convert integer to "GenreType" enum equivalent based on enum index, if no enum index associated will default to 0
            newContent.TypeOfGenre = (GenreType)genreInt;

            bool updateResult = _repo.UpdateContent(title, newContent);

            if (updateResult) {
                Console.Clear();
                System.Console.WriteLine("Content successfully updated!");
            } else {
                Console.Clear();
                System.Console.WriteLine("there was an issue when updating your content");
            }
        } else {
            System.Console.WriteLine("there is no content with that title... try option 2 from the menu to see what you are able to view");
        }
    }
    // delete


    // ! HELPER METHODS
    private void Seed() {
        StreamingContent movie1 = new StreamingContent("Car Wash", "snoop dogg, ice cube and the gang get reckless at a car wash store", 4.2, MaturityRating.R, GenreType.Comedy);
        StreamingContent movie2 = new StreamingContent("Avatar", "a parapalegic soldier discovers a whole new world. cgi is off the chain", 4.8, MaturityRating.PG13, GenreType.SciFi);
        StreamingContent movie3 = new StreamingContent("A Goofy Movie", "Goofy goes on a journey of fatherhood and discovery when his son Max goes off to college", 4.9, MaturityRating.PG, GenreType.Comedy);

        _repo.AddContentToDirectory(movie1);
        _repo.AddContentToDirectory(movie2);
        _repo.AddContentToDirectory(movie3);
    }
    private void DisplayContent(StreamingContent content) {
        // @ symol before a string allows you to include multiple lines of code without needing to concatinate the string.
        // @ symbol can also be used with $ symbol ($@) to use multiple lines AND variables
        System.Console.WriteLine($@"{content.Title} | {content.StarRating} stars:
        Rated {content.MaturityRating}

        Genre: {content.TypeOfGenre}

        {content.Description}
        
        {(content.IsFamilyFriendly ? "this content is family friendly!" : "this content is NOT family friendly")}
        
        ");
    }
}