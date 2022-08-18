using StreamingContentRepository;

public class ProgramUI {
    private Repository _repo = new Repository();

    public void Run() {
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
                    System.Console.WriteLine("view all");
                    break;
                case "3":
                    System.Console.WriteLine("view one");
                    break;
                case "4":
                    System.Console.WriteLine("update");
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
    // view one
    // update
    // delete
}