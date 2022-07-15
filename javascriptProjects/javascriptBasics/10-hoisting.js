// hoisting: storing a variable in memory so that it can referenced/used throughout the program
// * CREATION PHASE: any variables (var, const, let) OR functions from code being stored in memory
// * EXECUTION PHASE: values being assigned to the variable/function that were stored in memory during creation phase

/*
    (create) (execute)
    let variable = value
*/

// let num = 18

// console.log(num)

// ! FUNCTION DECLARATION
// sayHi()

// function sayHi() {
    //     console.log("HI!")
    
    //     let hi = "Waddup"
    //     console.log(hi)
    // }
    

// ! FUNCTION EXPRESSION
let varFunc = function() {
    console.log("fart")
}

varFunc()