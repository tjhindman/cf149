// ! SCOPE: heirarchy of variables in our code (access rights for variables)
// GLOBAL scope (PARENT scope)
// LOCAL scope (CHILD scope)

let global = "Earth"

function scopeExample() {
    // remembered for as long as the function executes, then forgotten about
    let local = "Indy"

    console.log(local)
    // TEMPLATE STRINGS (TEMPLATE LITERALS) = ``
    console.log(`I'm in ${local} which is a part of ${global}`)
}

scopeExample()