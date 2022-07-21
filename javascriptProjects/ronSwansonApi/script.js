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
*/

const quoteContainer = document.querySelector(".quoteContainer")
const logo = document.getElementById("ronLogo")

fetch("http://ron-swanson-quotes.herokuapp.com/v2/quotes")
    .then(res => res.json())
    .then(data => {
        console.log(data[0])
    })