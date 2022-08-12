Vehicle charger = new Vehicle();

charger.Make = "Dodge";
charger.Model = "Charger";
charger.Mileage = 0;
charger.Year = 2022;
charger.VehicleType = VehicleType.Car;
charger.RightIndicator = new Indicator();
charger.LeftIndicator = new Indicator();

System.Console.WriteLine($"Damn you got a {charger.Year} {charger.Make} {charger.Model} with {charger.Mileage} miles!\n");

charger.TurnOn();
charger.IndicateLeft();
charger.IndicateRight();
System.Console.WriteLine($"right indicator is running: {charger.RightIndicator.IsFlashing}\nleft indicator is running: {charger.LeftIndicator.IsFlashing}");
charger.TurnOnHazards();
System.Console.WriteLine($"right indicator is running: {charger.RightIndicator.IsFlashing}\nleft indicator is running: {charger.LeftIndicator.IsFlashing}");
charger.TurnOff();
System.Console.WriteLine($"right indicator is running: {charger.RightIndicator.IsFlashing}\nleft indicator is running: {charger.LeftIndicator.IsFlashing}\n");
charger.TurnOn();
System.Console.WriteLine(charger.IsRunning ? "The vehicle is running\n" : "Not running\n");

Person tj = new Person();

tj.First = "TJ";
tj.Last = "Hindman";
tj.Dob = new DateTime(1997, 01, 10);
tj.Transport = new Vehicle();

// constructor example
Person gordonRamsey = new Person("Gordon", "Ramsay", new DateTime(1966, 11, 8), new Vehicle());

System.Console.WriteLine($"This is {gordonRamsey.First} {gordonRamsey.Last} they were born {gordonRamsey.Dob} and are {gordonRamsey.Age} years old. They drive a {gordonRamsey.Transport.Year} {gordonRamsey.Transport.Make} {gordonRamsey.Transport.Model}.\n");

// class method ex
Greeter greeter = new Greeter();

greeter.SayHello();
greeter.SayHello("Michael");

// calculator ex
Calculator calculator = new Calculator();

System.Console.WriteLine($"Add integer: {calculator.Add(15, 22)}\nAdd double: {calculator.Add(1.2, 22.1)}\nSubtract: {calculator.Subtract(400, 22)}\nMultiply: {calculator.Multiply(90, 49)}\nDivide: {calculator.Divide(100,2)}\n");

/*
    PROPERTIES IN C# CLASSES:

    1: access modifier = where can it be seen?
    2: data type = what type of data will be expected to be stored
    3: name
    4: getters/setters
*/
public class Vehicle {
    // 1    2       3       4
    public string? Make { get; set; } = "Unkown Manufacturer";
    public string? Model { get; set; } = "Car";
    public double Mileage { get; set; }
    public int Year { get; set; } = 1900;
    public VehicleType VehicleType { get; set; } = VehicleType.Car;
    public bool IsRunning { get; private set; }
    public Indicator? RightIndicator { get; set; }
    public Indicator? LeftIndicator { get; set; }
    public void TurnOn() {
        IsRunning = true;

        System.Console.WriteLine($"you turned on the {Model}");
    }
    public void TurnOff() {
        IsRunning = false;

        ClearIndicators();
        System.Console.WriteLine($"you turned off the {Model}");
    }
    public void IndicateRight() {
        RightIndicator.TurnOn();
        LeftIndicator.TurnOff();
    }
    public void IndicateLeft() {
        LeftIndicator.TurnOn();
        RightIndicator.TurnOff();
    }
    public void TurnOnHazards() {
        RightIndicator.TurnOn();
        LeftIndicator.TurnOn();
    }
    private void ClearIndicators() {
        RightIndicator.TurnOff();
        LeftIndicator.TurnOff();
    }
}

public class Indicator {
    public bool IsFlashing { get; private set; }

    public void TurnOn() {
        IsFlashing = true;
    }
    public void TurnOff() {
        IsFlashing = false;
    }
}

// ! ENUMs

public enum VehicleType { Car, Truck, Bike, Spaceship, Plane, Boat }


// ! custom "get"/"set" and constructors

public class Person {
    // default constructor
    // - IF PARAMATERIZED CONSTRUCTOR IS INCLUDED HAVE TO ALSO INCLUDE THE DEFAULT CONSTRUCTOR
    public Person() {}
    // paramaterized constructor
    public Person(string first, string last, DateTime dob, Vehicle transport) {
        First = first;
        Last = last;
        Dob = dob;
        Transport = transport;
    }
    public string? First { get; set; }
    // what's happening behind the scenes
    private string? _last;
    public string? Last {
        get {
            return _last;
        }
        set {
            _last = value;
        }
    }
    public string FullName {
        get {
            return $"{First} {Last}";
        }
    }
    public DateTime Dob { get; set; }
    public int Age { 
        get {
            TimeSpan exactAge = DateTime.Now - Dob;
            int totalDays = (int)exactAge.TotalDays;
            // type casting (parentheses with data type before variable/data)
            double yearsUnrounded = (double)totalDays / 365.24;
            int years = (int)Math.Floor(yearsUnrounded);

            return years;
        } 
    }
    public Vehicle? Transport { get; set; }
}


// ! METHODS IN CLASSES
/*
    1: access modifier (see above)
    2: return type = what type of data is expected to be returned. if nothing is returned should be "void"
    3: method signature = name followed by parentheses and any arguments that may be included
    4: body of code that is executed
*/
public class Greeter {
    // 1    2       3
    public void SayHello() {
        // 4
        System.Console.WriteLine("What's good!\n");
    }

    // overloading methods
    public void SayHello(string name) {
        System.Console.WriteLine($"What's good {name}!\n");
    }
}

public class Calculator {
    public int Add(int numOne, int numTwo) {
        return numOne + numTwo;
    }

    public double Add(double numOne, double numTwo) {
        return numOne + numTwo;
    }

    // Subtract
    public int Subtract(int numOne, int numTwo) {
        return numOne - numTwo;
    }

    // Multiply
    public int Multiply(int numOne, int numTwo)
    {
        return numOne * numTwo;
    }

    // Divide
    public int Divide(int numOne, int numTwo)
    {
        return numOne / numTwo;
    }
}