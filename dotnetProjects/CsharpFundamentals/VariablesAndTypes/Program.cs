// single line comment in C# (2 forward slashes)

/*
    multi line comment in C#

    can put as many lines as you want
*/

/// XML COMMENTS
/// these are used to add definition for specific items in your code

// ! VALUE TYPES

// boolean data type
bool isDeclared;

isDeclared = true;

bool isDeclaredAndInitialized = false;

isDeclaredAndInitialized = true;

// character data type - MUST USE SINGLE QUOTES
char letter = 't';
char symbol = '?';
char num = '3';
char space = ' ';
char specialChar = '\n';

/* 
    number data TYPES 
    
    - integer types [whole #s]
    - floating point types [decimal #s]
*/

// integer types
int wholeNum = 14;

// floating point types
// * "double" is preffered over "float"
double doubleEx = 15.230490;
// double detailedDoubleEx = 13.2124d;
// * "float" have to end with "f"
float floatEx = 3.14159275f;
// * "decimal" have to end with "m"
decimal decimalEx = 1000.30832m;

System.Console.WriteLine($"double: {doubleEx}\nfloat: {floatEx}\ndecimal: {decimalEx}");

// string data type
string helloWorld = "Hello world!";