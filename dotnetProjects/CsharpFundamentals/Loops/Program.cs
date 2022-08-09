// ! WHILE LOOPS

int total = 10;

while (total > 1)
{
    System.Console.WriteLine($"total is: {total}");
    // total = total - 1
    total--;
}

// * alternative for exiting "while" loop ("break" statement)

total = 0;

while (true)
{
    if (total == 5)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("total is 5");
        break;
    }

    total++;
}


// ! FOR LOOPS

for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
}

string[] students = { "Mike T", "David", "Cassandra", "Clarissa"};

for (int i = 0; i < students.Length; i++)
{
    System.Console.WriteLine($"What's good {students[i]}");
}

// ! FOREACH LOOPS

/*
    1 = data type in collection being looped over
    2 = name for current index being looped
    3 = collection being looped over
*/

//          1       2   "in"    3
foreach (string student in students)
{
    System.Console.WriteLine($"this is {student}");
}

string intro = "Welcome everybody";

foreach (char letter in intro)
{
    if (letter == 'e')
    {
        System.Console.WriteLine("elite");
    }
}


// ! DO/WHILE LOOPS

int iterator = 0;

do
{
    System.Console.WriteLine($"iterator is {iterator}");
    iterator++;
}
while (iterator < 5);

do
{
    System.Console.WriteLine("this should not show");
}
while (false);