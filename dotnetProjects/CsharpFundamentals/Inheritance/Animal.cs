// "abstract" keyword specifies that instance of class cant be created (class can only be used as a type)
public abstract class Animal {
    public Animal() {
        System.Console.WriteLine("this is the Animal constructor.");
    }

    public int NumLegs { get; set; }
    public bool HasFur { get; set; }
    public bool HasTail { get; set; }
    public int NumTeeth { get; set; }
    public string BloodType { get; set; }
    public DietType TypeOfDiet { get; set; }
}

public enum DietType { Omnivores, Carnivores, Herbivores }