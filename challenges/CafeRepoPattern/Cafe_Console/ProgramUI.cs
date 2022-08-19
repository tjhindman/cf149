using Cafe_Repository;

public class ProgramUI {
    CafeRepository _repo = new CafeRepository();

    public void Run() {
        Seed();
        Menu();
    }

    private void Menu() {
        bool keepRunning = true;

        while (keepRunning) {
            Console.Clear();

            System.Console.WriteLine("Please select from the following options:\n" 
                + "1. Create new menu item\n"
                + "2. View menu items\n"
                + "3. Update item by menu item number\n"
                + "4. Delete item by menu item number\n"
                + "5. Exit");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewItem();
                    break;
                case "2":
                    ViewAllItems();
                    break;
                case "3":
                    UpdateItem();
                    break;
                case "4":
                    DeleteItem();
                    break;
                case "5":
                    Console.Clear();
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

    private void CreateNewItem() {
        Console.Clear();

        MenuItem newItem = new MenuItem();

        newItem.MealNum = _repo.GetAllItems().Count + 1;

        System.Console.WriteLine("Please enter a name for your new menu item...");
        newItem.Name = Console.ReadLine();
        
        System.Console.WriteLine("Please enter a description for your new item...");
        newItem.Description = Console.ReadLine();

        
        System.Console.WriteLine("Please enter the ingredients for your new item...");
        newItem.ListOfIngredients = Console.ReadLine();
        
        System.Console.WriteLine("Please enter the price for your new item...");
        newItem.Price = double.Parse(Console.ReadLine());

        bool itemAdded = _repo.AddNewItem(newItem);

        if(itemAdded) {
            Console.Clear();
            System.Console.WriteLine("Item added!\n");
        } else {
            Console.Clear();
            System.Console.WriteLine("creating new menu item was unsuccessful\n");
        }
    }

    private void ViewAllItems() {
        Console.Clear();
        
        foreach (MenuItem item in _repo.GetAllItems())
        {
            DisplayItem(item);
        }
    }

    private void UpdateItem() {
        Console.Clear();
        
        System.Console.WriteLine("Please enter the menu number of the item you would like to update...");

        int menuNum = int.Parse(Console.ReadLine());
        MenuItem newItem = new MenuItem();

        System.Console.WriteLine("Please enter a new name for this item. If not press enter...");
        newItem.Name = Console.ReadLine();
        
        System.Console.WriteLine("Please enter a new description. If not press enter...");
        newItem.Description = Console.ReadLine();
        
        System.Console.WriteLine("Please enter a new ist of ingredients. If not press enter...");
        newItem.ListOfIngredients = Console.ReadLine();
        
        System.Console.WriteLine("Please enter a new price. If not press enter...");
        newItem.Price = double.Parse(Console.ReadLine());

        bool updateSuccess = _repo.UpdateItem(menuNum, newItem);

        if (updateSuccess)
        {
            Console.Clear();
            
            System.Console.WriteLine("Update was successful!");
        } else {
            Console.Clear();
            
            System.Console.WriteLine("something went wrong...");
        }
    }

    private void DeleteItem() {
        Console.Clear();
        
        System.Console.WriteLine("Please enter the menu number of the item you would like to delete...");

        int menuNum = int.Parse(Console.ReadLine());
        
        bool deleteSuccess = _repo.DeleteItem(menuNum);

        if (deleteSuccess)
        {
            Console.Clear();
            
            System.Console.WriteLine("Delete successful!");
        } else
        {
            Console.Clear();
            
            System.Console.WriteLine("There was a problem deleting your item sir/ma'am/person");
        }
    }

    private void DisplayItem(MenuItem item) {
        System.Console.WriteLine($"Item #{item.MealNum}: {item.Name}\n"
        + "--------------\n"
        + $"$ {item.Price}\n"
        + $"{item.ListOfIngredients}");
        System.Console.WriteLine();
        System.Console.WriteLine($"{item.Description}");
        System.Console.WriteLine();
        System.Console.WriteLine();
    }

    private void Seed() {
        MenuItem crabBoil = new MenuItem(_repo.GetAllItems().Count + 1, "Crab Boil", "the most delicious, mouth watering, scrumptious cobination of some of the most delicate seafood this planet has ever known", "crab, garlic, spices, butter, shrimp, sausages, potatoes, corn on the cob, boiled egg", 36.00);
        _repo.AddNewItem(crabBoil);

        MenuItem pepperoniPizza = new MenuItem(_repo.GetAllItems().Count + 1, "Pep pizza", "an italian american delicacy topped with tomato sauce, mozzarella cheese and pepperoni pizza on a bedding of soft dough", "dough, sauce, cheese, pepperoni", 5.00);
        _repo.AddNewItem(pepperoniPizza);
    }
}