System.Console.WriteLine("------ operators ------");
// Addition! "+"

int a = 3;
int b = 417;

int addTotal = a + b;

Console.WriteLine($"Add Total: {addTotal}");


// Subtraction! "-"

int subTotal = 423 - a;

Console.WriteLine($"Subtraction Total: {subTotal}");


// Multiplication! "*"

int multTotal = a * 23;

Console.WriteLine($"Multiplication Total: {multTotal}");


// Division! "/"

int divTotal = b / a;

Console.WriteLine($"Division Total: {divTotal}");


// Remainder! "%"

int remainder = b % a;

Console.WriteLine($"Remainder of 3 into 417: {remainder}");


// Operators with other data types

DateTime today = DateTime.Now;
DateTime bday = new DateTime(1997, 1, 10);

TimeSpan age = today - bday;

Console.WriteLine($"Date/Time calculation: {age.ToString("%d")} days");


// ! COMPARISON OPERATORS

// equality: "=="
System.Console.WriteLine("\n------ equality ------");

int newAge = 50;
string name = "TJ";

bool isEqual = newAge == 21;

Console.WriteLine($"newAge == 21: {isEqual}");


// inequality: "!="
System.Console.WriteLine("\n------ inequality ------");

bool isNotEqual = name != "Darneisha";

Console.WriteLine($"name != 'Darneisha': {isNotEqual}");

// * inequality with "reference types" (classes/structs)

List<string> first = new List<string>() {"tj"};

List<string> second = new List<string>() {"tj"};

bool isListEqual = first == second;

// this would make it true
// bool isListEqual = first[0] == second[0];

Console.WriteLine($"first == second: {isListEqual}");


// greater/less than
System.Console.WriteLine("\n------ greater than/less than/greater or equal/less or equal ------");

bool greaterThan = newAge > 40;

Console.WriteLine($"newAge > 40: {greaterThan}");

bool lessThan = newAge < 40;

Console.WriteLine($"newAge < 40: {lessThan}");

bool greaterThanOrEqual = newAge >= 51;

Console.WriteLine($"newAge >= 51: {greaterThanOrEqual}");

bool lessThanOrEqual = newAge <= 51;

Console.WriteLine($"newAge <= 51: {lessThanOrEqual}");


// AND/OR operators [&&  or ||]

bool trueVar = true;
bool falseVar = false;

// AND (always false unless both are true)
System.Console.WriteLine("\n------ AND operator ------");
Console.WriteLine($"true && true: {trueVar && trueVar}");
Console.WriteLine($"true && false: {trueVar && falseVar}");
Console.WriteLine($"false && true: {falseVar && trueVar}");
Console.WriteLine($"false && false: {falseVar && falseVar}");

// OR (always true unless both are false)
System.Console.WriteLine("\n------ OR operator ------");
Console.WriteLine($"true || true: {trueVar || trueVar}");
Console.WriteLine($"true || false: {trueVar || falseVar}");
Console.WriteLine($"false || true: {falseVar || trueVar}");
Console.WriteLine($"false || false: {falseVar || falseVar}");