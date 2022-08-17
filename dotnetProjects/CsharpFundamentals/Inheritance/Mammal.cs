// SYNTAX FOR INHERITANCE
public class Mammal : Animal {
    public Mammal() { }
    public Mammal(int numLegs, bool hasTail, int numTeeth, DietType typeOfDiet, string furColor) {
        HasFur = true;
        BloodType = "warm";

        NumLegs = numLegs;
        HasTail = hasTail;
        NumTeeth = numTeeth;
        TypeOfDiet = typeOfDiet;

        FurColor = furColor;
        System.Console.WriteLine("this is the Mammal constructor");
    }

    public string FurColor { get; set; }
}