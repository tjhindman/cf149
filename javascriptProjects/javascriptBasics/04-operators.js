// OPERATORS

// ASSIGNMENT OPERATOR
// The = sign in between our variableName and our values. Helps assign values to our declarations.
let r = 5;

// COMPARISON OPERATORS
// EQUAL TO
console.log(3 == 3); //true
console.log("3" == 3); //true
// COERCION is happening and JS assumes that we are doing "3" == "3". It converted that number into a string.

// STRICT EQUAL TO
console.log("3" === 3); //false
// COERCION does NOT happen here. So strictly equals to is checking the data type and the value.

// NOT EQUALS TO
console.log("3" != 3); // false because coercion is happening and "3" does equal "3" (We're not type checking here)

// STRICTLY NOT EQUAL TO
console.log("3" !== 3); //true because the string data type of 3 does NOT equal the number 3.

// GREATER THAN
console.log(3 > 2);

// LESS THAN
console.log(2 < 3);

// GREATER THAN OR EQUAL TO
console.log(3 >= 2);

// LESS THAN OR EQUAL TO
console.log(2 <= 3);

// AND &&
console.log(2 < 3 && 3 > 2); // true because both expression on either side of && are true.
console.log(2 < 3 && 3 < 2); // false because 3 < 2 and the other expression is true so we get false.
console.log(5 < 4 && 12 > 24); // false because both expressions are false.

// OR ||
console.log(2 < 3 || 3 < 2); // true because one of our statements is true.

// LOGIC OPERATORS

// ADDITION
r = r + 1;
r += 1;

// SUBTRACTION
r = r - 1;
r -= 1;

// MULTIPLICATION
r = r * 1;
r *= 1;

// DIVISION
r = r / 1;
r /= 1;

// EXPONENTIAL
r = r ** 2;
r **= 2;

// MODULUS
console.log(5 % 2);
