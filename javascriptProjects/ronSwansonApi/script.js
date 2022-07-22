/*
    - "synchronous" programming is read line by line
    - "asynchronous" programming allows a program to do more than one thing at a time

    APIs:
    - stands for "Application Programming Interface"
    - NOT the database/server. allows for communication with these things (through endpoints)

    REST = REpresentational State Transfer
    - process of creating an object of requested data, and sending values as a response to the user making the request

    CRUD = Create, Read, Update, Delete
    - Create (POST requests)
    - Read (GET requests)
    - Update (PUT requests)
    - Delete (DELETE requests)

    ASYNC/AWAIT:
    - allows us to program in a "synchronous" manner using async code dealing with APIs
    - makes our sites as responsive/user friendly as possible
*/

const quoteContainer = document.querySelector(".quoteContainer")
const logo = document.getElementById("ronLogo")

/*
    - "async" keyword can be used on a normal function to make it "asynchronous"
    - this allows for other code to continue running by specifying that the "async" function is expecting to have to wait to finish executing
    - "async" keyword gives us access to the "await" keyword to specify what the code should expect to "wait" for
    - "try/catch" blocks needed to wrap around code that has to be "waited" on to account for error handling inside of "catch" block
*/
const fetchQuote = async () => {
    try {
        const res = await fetch("http://ron-swanson-quotes.herokuapp.com/v2/quotes")
        const data = await res.json()
    
        displayQuote(data[0])
    } catch (err) {
        console.log(`Error: ${err}`)
    }
}

function displayQuote(data) {
    console.log(data)
    // logic for removing original logo button from page
    const logoContainer = document.getElementById("genQuote")
    // * "<elementVar>.firstElementChild" used to check if there is a child element inside of element being specified
    // * alternative for writing a ternary
    logoContainer.firstElementChild != null 
        // if true
        ? logoContainer.removeChild(logo) 
        // if false
        : null

    // logic for adding new quote to the page
    const author = document.createElement('p')
    author.innerText = "- Ron Swanson"
    author.style = "font-size: 3rem; font-family: billionDreams; color: #3a2718;"

    const quote = document.createElement('h1')
    quote.innerText = data
    quote.style = "font-family: pinewood; color: #3a2718;"

    // checking length of quote to determine font size for the element
    if(data.length >= 50 && data.length <= 150) {
        quote.style.fontSize = "5rem"
    } else if (data.length < 50) {
        quote.style.fontSize = "7rem"
    } else {
        quote.style.fontSize = "3.5rem"
    }
    
    const image = document.createElement("img")
    image.src = "./assets/ron.png"
    image.alt = 'Ron Swanson'
    image.style = "height: 100px; width: auto;"

    quoteContainer.appendChild(quote)
    quoteContainer.appendChild(author)
    quoteContainer.appendChild(image)

    image.addEventListener("click", () => {
        quoteContainer.removeChild(quote)
        quoteContainer.removeChild(author)
        quoteContainer.removeChild(image)

        fetchQuote()
    })
}

logo.addEventListener("click", fetchQuote)
