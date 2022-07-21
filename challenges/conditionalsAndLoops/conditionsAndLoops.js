/*
    1. Print every letter of the word "Supercalifragilisticexpialidocious" to the console, one at a time.
    2. Next, do the same, except only print the letter if it's an 'i'. If it's any other letter, print "Not an i".

    Bonus: After that, print the number of letters in the word (do this with code, not by counting manually and hard-coding the number).

    Another Bonus: In part 2, also determine if the letter is 'L'. If it is, print 'L'.
*/

const word = "Supercalifragilisticexpialidocious"
const wordArray = word.split("")

// console.log(wordArray)

let letterCount = 0

for (letter of wordArray) {
    // same as letterCount = letterCount + 1
    letterCount++

    if (letter === 'i') {
        console.log(letter)
    } else if (letter === "l") {
        console.log(letter)
    }else {
        console.log("Not an i.")
    }
}

console.log(`Number of letters: ${letterCount}`)
console.log(`Number of letters (array length): ${wordArray.length}`)