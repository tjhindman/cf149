// ! IF STATEMENTS

// bool isHungry = false;

// // only executes the code block "if" true
// if (isHungry)
// {
//     System.Console.WriteLine("Order some pizza dude!");
// }

// // ! IF/ELSE STATEMENTS

// // gives an option for what to execute if the condition is false
// if (isHungry)
// {
//     System.Console.WriteLine("get some Culver's");
// } 
// else
// {
//     System.Console.WriteLine("chill out and watch some tv");
// }

// // ! ELSE IF STATEMENTS and NESTING CONDITIONALS

// int age = 50;

// if (age < 10)
// {
//     System.Console.WriteLine("it's past your bedtime go to bed");
// }
// else
// {
//     if (age < 18)
//     {
//         System.Console.WriteLine("you're out past curfew");
//     }
//     else if (age < 21)
//     {
//         System.Console.WriteLine("get out of the bar or I'll call the cops");
//     }
//     else
//     {
//         System.Console.WriteLine("enjoy the party!");
//     }
// }


// // ! IF/ELSE STATEMENTS WITH COMPARISON OPERATORS

// if (age > 51 || age < 70)
// {
//     System.Console.WriteLine("enjoy retirement!");
// }
// else if (age == 50)
// {
//     System.Console.WriteLine("halfway to a century!");
// }
// else if (age < 50 && age > 21)
// {
//     System.Console.WriteLine("get to work!");
// }
// else
// {
//     System.Console.WriteLine("go to school!");
// }

/*
    SWITCH CASES!!

    - the "switch" keyword, followed by the statement/value being evaluated (in parentesis)
    - inside curly braces, there are different "cases" followed by potential values for the statement being evaluated
    - after each case logic, must be followed by a "break" statement to break out of the case
*/

string mood = "happy";

switch (mood)
{
    case "happy":
        System.Console.WriteLine("glad you're happy!");
        break;
    case "sad":
        System.Console.WriteLine("hope you feel better buddy");
        break;
    case "excited":
        System.Console.WriteLine("turn up!");
        break;
    // "default" case is basically the "else" statement
    default:
        System.Console.WriteLine("idk what you are");
        break;
}

// ! SWITCH EXPRESSIONS

string output;
int action = 5;

output = action switch
{
    1 => "1",
    2 => "2",
    3 => "3",
    // "default" case
    _ => "idk",
};

/*
switch (action)
{
    case 1:
        output = "1";
        break;
    case 2:
        output = "2";
        break;
    case 3:
        output = "3";
        break;
    default:
        output = "idk";
        break;
}
*/

System.Console.WriteLine(output);


// ! TERNARY STATEMENTS

// boolean variable/statement ? trueConditionToBeReturned : falseConditionToBeReturned
int studentCount = 100;

string outputTwo = studentCount > 50 ? "you got alot on your plate" : "good luck";

System.Console.WriteLine(studentCount == 100 ? "100" : "not 100");
System.Console.WriteLine(outputTwo);