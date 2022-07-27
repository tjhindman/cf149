/*
FIZZBUZZ LOOP CHALLENGE (pair coding)
************
- write a conditional that:
        - prints out "Fizz" if the number is divisible by 3
        - prints out "Buzz" if the number is divisible by 5
        - prints out "Fizz Buzz" if the number is divisible by BOTH 3 and 5
        - prints out the number if none of the above are true.
- create a loop that counts to 100.
- Pass each iteration through a conditional.
*/

// * IF/ELSE option 1
// for (let i = 1; i <= 100; i++) {
//     // first number that is divisible by both 3 and 5 is 15
//     if(i % 15 === 0) {
//         console.log("Fizz Buzz")
//     } else if (i % 3 === 0) {
//         console.log("Fizz")
//     } else if (i % 5 === 0) {
//         console.log("Buzz")
//     } else {
//         console.log(i)
//     }
// }

// * IF/ELSE option 2
// for (let i = 1; i <= 100; i++) {
//     // ONLY if both conditions are evaluated as "true", "&&" will return "true"
//     if(i % 3 === 0 && i % 5 === 0) {
//         console.log("Fizz Buzz")
//     } else if (i % 3 === 0) {
//         console.log("Fizz")
//     } else if (i % 5 === 0) {
//         console.log("Buzz")
//     } else {
//         console.log(i)
//     }
// }

// * SWITCH option
// for (let i = 1; i <= 100; i++) {
//     switch (true) {
//         case i % 3 === 0 && i % 5 === 0:
//             console.log("Fizz Buzz")
//             break
//         case i % 3 === 0:
//             console.log("Fizz")
//             break
//         case i % 5 === 0:
//             console.log("Buzz")
//             break
//         default:
//             console.log(i)
//     }
// }

// * TERNARY option (kinda ugly)
for (let i = 1; i <= 100; i++) {
    i % 3 === 0 && i % 5 === 0
        ? console.log("Fizz Buzz")
        : i % 3 === 0
            ? console.log("Fizz")
            : i % 5 === 0
                ? console.log("Buzz")
                : console.log(i)
}