public class Amphibian : Animal {
    public Amphibian() { }
    public Amphibian(int numLegs, bool hasTail, int numTeeth, DietType typeOfDiet, string skinColor, bool camoflauge) {
        HasFur = false;
        BloodType = "cold";


        NumLegs = numLegs;
        HasTail = hasTail;
        NumTeeth = numTeeth;
        TypeOfDiet = typeOfDiet;

        SkinColor = skinColor;
        Camoflauge = camoflauge;
        System.Console.WriteLine("this is the Amphibian constructor.");
    }

    public string SkinColor { get; set; }
    public bool Camoflauge { get; set; }
}