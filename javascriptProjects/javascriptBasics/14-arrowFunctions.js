// * ARROW FUNCTIONS "fat arrow" functions are not hoisted
// ! - "concise" body (no curly braces... whatever is after "fat arrow" is automatically returned/executed)
// ! - "block" body (include curly braces and explicitly need "return" keyword to return any data)

// ! CONCISE BODY
// - automatically execute example:
let speak = (noise) => console.log(`${noise}! ${noise}!`)
// speak("Bark")

// - automatically return data after "fat arrow"
let showFullName = (first, last) => `${first} ${last}`

// console.log(`dude giving the lecture is named ${showFullName("TJ", "Hindman")}`)

// ! BLOCK BODY (using curly braces)
// - include extra functionality (multiple lines of code) before specifying a "return" value
let speakAgain = (noise) => {
    let time = "later"

    console.log(`${noise} ${time}! ${noise} ${time}!`)
}

// speakAgain("Meow")

let showDisName = (first, last) => {
    return `${first} ${last}`
}

console.log(`This dude is named ${showDisName("Mallory", "Fronterhouse")}`)