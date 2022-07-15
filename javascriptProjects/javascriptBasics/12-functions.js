/* TYPES OF FUNCTIONS:
    - Function declaration
    - Function expression
    - Anonymous functions
*/

// ! FUNCTION DECLARATION
// - are hoisted (are available anywhere in the program)
function declaration() {
    console.log("This is the function body!")
}

// ! FUNCTION EXPRESSIONS
// - are NOT hoisted after creation... stored within a variable
let expression = function() { // <--- "anonymous" function
    console.log("this is a function expression!")
}