// CONDITIONALS

// Conditionals control the behavior of JS and determines whether or not pieces of code are allowed to run. (either or situation). They are used to perform different actions based on certain conditions.

/*
    TRUTHY VALUES:
    - true
    - {}
    - []
    - 42/-42 (positive or negative integers)
    - "0" / "false"

    FALSY VALUES:
    - false
    - null
    - undefined
    - 0
    - NaN (NOT A NUMBER)
    - " " //Empty string

    NOTE: A conditional will only run if it is a "truthy" value. (If the condition is true).
*/

/*
    SYNTAX:

    if (condition) {
        NESTED LOGIC
    }
*/

// let snowing = true;

if (snowing == true) {
  console.log("It is snowing outside!");
}

if (snowing) {
  console.log("It is still snowing!");
}

let snowing = false;

if (snowing == false) {
  console.log("It stopped snowing. It's too warm.");
}

if (snowing) {
  console.log("It is not snowing. Bummer!");
}

let weather = 65;

if (weather < 70) {
  console.log("Wear a coat 'cause it is too dang cold!");
}

// IF ELSE - if the first condition is false, then it will run the next block of code as a default.

let kittens = 3;

if (kittens < 1) {
  console.log("I need more kittens");
} else {
  console.log("I have enough kittens");
}

// ELSE IF - specifies a new condition to test, if the first condition is false.

let apples = 14;

if (apples < 10) {
  console.log("Not enough apples.");
} else if (apples < 15) {
  console.log("Still not enough apples!");
} else {
  console.log("Just right");
}

// SWITCH STATEMENTS - execute a block of code depending on different cases
// NOTE: Switch statements are gonna act like our conventional conditionals just different syntax

// breaks - keyword that breaks out of the switch block. Break stops the execution of more code or case testing inside of the block.
// default - acts as our else keyword.
// case - () to hold our condition.
let harryPotterCharacter = "Hermione";

switch (harryPotterCharacter) {
  case "Harry Potter":
    console.log("Is a whiny boy");
    break;
  case "Hermione":
    console.log("Great character. 10 out of 10 would recommend.");
    break;
  case "Ron":
    console.log("Eats food, I guess.");
    break;
  default:
    console.log(`I'm sorry, ${harryPotterCharacter}, but do I know you?`);
}

/*
    CHALLENGE
    Using a switch statement, write a dessert menu;
    If the dessert is pie, console.log("Pie, pie, pie, me oh my");
    If the dessert is cake, console.log("Cake is great");
    If the dessert is ice cream, console.log("I scream for ice cream");
    Otherwise, have your switch statement console.log("Not on the menu!");
*/

let dessert = "PIE";

switch (dessert) {
  case "PIE":
    console.log("Pie, pie, pie, me oh my");
    break;
  case "cake":
    console.log("Cake is great");
    break;
  case "ice cream":
    console.log("I scream for ice cream");
    break;
  default:
    console.log("Not on the menu!");
}

// SWITCH STATEMENTS WITH MULTIPLE CONDITIONS
let num = -40;

switch (true) {
  case num < 0 && num > -10:
    console.log("Oh hey there!");
    break;
  case num > 0:
    console.log("Hey friend!");
    break;
  default:
    console.log("So long, buddy!");
}

// TERNARIES - This is the shorthand way of writing out if/else and else/if statements.
// NOTE: The only difference between ternaries and if/else is the syntax.

let number = 6;

if (number > 0) {
  console.log("Yes, your number is greater than 0.");
} else {
  console.log("No, your number is not greater than 0.");
}

number > 0
  ? console.log("Yes your number is great than 0")
  : console.log("No your number is not greater than 0");

number == 0
  ? console.log("Your number is equal to 0")
  : number < 0
  ? console.log("Your number is less than 0")
  : console.log("Your number is greater than 0");

// NOTE: ternaries need a catch all (else) unlike our conventional if conditionals.

/*
CHALLENGE
    Write out a conditional, then switch statement, and then ternary about ages. 
    If you're over the age of 18, print out "Yay! You can vote!"
    If you're over the age of 21, print out "Yay! You can drink!"
    If you're over the age of 25, print out "Yay! You can rent a car!"
    If you're younger than 18, print out "Sorry, you're too young to do anything fun."

    HINT: Make sure to check your work with different values.
*/

let myAge = 25;

// if (myAge > 18) {
//   console.log("Yay You can vote!");
// } else if (myAge > 21) {
//   console.log("Yay! You can drink!");
// } else if (myAge > 25) {
//   console.log("Yay! You can rent a car!");
// } else {
//   console.log("Sorry, you're too young to do anything");
// }

if (myAge >= 25) {
  console.log("Yay! You can rent a car!");
} else if (myAge >= 21) {
  console.log("Yay! You can drink!");
} else if (myAge >= 18) {
  console.log("Yay! You can vote");
} else {
  console.log("Sorry you're too young to do anything");
}

switch (true) {
  case myAge >= 25:
    console.log("Yay! You can rent a car!");
    break;
  case myAge >= 21:
    console.log("Yay! You can drink!");
    break;
  case myAge >= 18:
    console.log("Yay! You can vote");
    break;
  default:
    console.log("Sorry you're too young to do anything");
}

/*
  CHALLENGE:
  Create a variable named FB that takes on a number (it can be any number you want)
  Print out "Fizz" if the number is divisible by 3
  Print out "Buzz" if the number is divisible by 5
  Print out "Fizz Buzz" if the number is divisible by 3 and 5
  Print out the number if the number isn't divisible by 3 or 5

  EXTRA BROWNIE POINTS:
  Convert this to a switch statement and then a ternary.
*/

let FB = 15;

if (FB % 3 === 0) {
  console.log("Fizz");
} else if (FB % 5 === 0) {
  console.log("Buzz");
} else if (FB % 3 === 0 && FB % 5 === 0) {
  console.log("Fizz Buzz");
} else {
  console.log("20");
}

if (FB % 3 === 0 && FB % 5 === 0) {
  console.log("Fizz Buzz");
} else if (FB % 5 === 0) {
  console.log("Buzz");
} else if (FB % 3 === 0) {
  console.log("Fizz");
} else {
  console.log(FB);
}

// Switch
switch (true) {
  case FB % 3 === 0 && FB % 5 === 0:
    console.log("Fizz Buzz");
    break;
  case FB % 5 === 0:
    console.log("Buzz");
    break;
  case FB % 3 === 0:
    console.log("Fizz");
    break;
  default:
    console.log(FB);
}

// Ternary
FB % 3 === 0 && FB % 5 === 0
  ? console.log("Fizz Buzz")
  : FB % 5 === 0
  ? console.log("Buzz")
  : FB % 3 === 0
  ? console.log("Fizz")
  : console.log(FB);
