namespace Cafe_Repository;

public class MenuItem
{
    /*
        - a unique meal number
        - meal name
        - description
        - "list" of ingredients
        - price
    */
    public MenuItem() {}

    public MenuItem(int mealNum, string name, string description, string listOfIngredients, double price) {
        MealNum = mealNum;
        Name = name;
        Description = description;
        ListOfIngredients = listOfIngredients;
        Price = price;
    }

    // should be assigned from CafeRepository.cs file
    public int MealNum { get; set; }
    
    public string Name { get; set; }

    public string Description { get; set; }
    
    public string ListOfIngredients { get; set; }
    
    public double Price { get; set; }
}
