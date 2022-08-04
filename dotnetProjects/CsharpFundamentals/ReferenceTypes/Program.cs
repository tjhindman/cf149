// strings are collection of "char" data types
string efa = "Eleven Fifty Academy";

// considered "null" and will throw an error if referred to in the code
string blankEfa;

// ! STRING MANIPULATION
string firstName = "TJ";
string lastName = "Hindman";

string concatenatedVar = firstName + " " + lastName;

// "composite formatting" allows you to declare spaces for the variable in the string and assign values for them inside the "formatting" method
// - argument indexes start at 0 for the string in the first argument
string compositeFormattedVar = string.Format("{0} {1}", firstName, lastName);

// string interpolation
string interpolatedString = $"{firstName} {lastName}";

// ! ARRAYS

string[] stringArray = {"this", "is", "an", "array", "of", "strings"};

stringArray[2] = "the";

System.Console.WriteLine($"{stringArray[0]} {stringArray[1]} {stringArray[2]} {stringArray[3]} {stringArray[4]} {stringArray[5]}");

// ! LISTS (typically preferred over arrays due to their ability to add/remove values)

List<int> intList = new List<int>();

intList.Add(9);
intList.Add(2);
intList.Add(4);

System.Console.WriteLine(string.Join(", ", intList));

// * List with predefined indexes
List<string> celebList = new List<string>() {"Drake", "snoop", "odb", "q tip"};

celebList.Add("kevin hart");
celebList.Add("whitney houston");

// extra ".WriteLine()" for blank space in console
System.Console.WriteLine();
System.Console.WriteLine(string.Join(", ", celebList));

// ! QUEUES (first in, first out -- like Apple Music queues [shoutout Cassandra!])

Queue<string> firstInFirstOut = new Queue<string>();

firstInFirstOut.Enqueue("Beyonce");
firstInFirstOut.Enqueue("Taylor Swift");
firstInFirstOut.Enqueue("Kesha");

// extra ".WriteLine()" for blank space in console
System.Console.WriteLine();
System.Console.WriteLine(string.Join(", ", firstInFirstOut));

// ! DICTIONARIES (used for creating a key/value)

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(10, "TJ");
keyAndValue.Add(4, "Hector");

System.Console.WriteLine();
System.Console.WriteLine(string.Join(", ", keyAndValue));

// when using square brackets with dictionaries, specify the KEY name
System.Console.WriteLine($"\n10 key: {keyAndValue[10]}");