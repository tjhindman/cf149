// LOOPS
// Loops allow developers to repeat a bit of code over and over.

/*
    FOR LOOPS - 3 different parameters. 1. initial expression (declaration), 2. condition, 3. increment expression

    SYNTAX:
    for (initial expression, condition, increment expression) {
        NESTED LOGIC
    }
*/

let i = 9; //globally scoped variable.

for (let i = 0; i <= 10; i++) {
  console.log(i);
}

console.log("This is coming from line 18", i);

for (i = 0; i <= 20; i++) {
  console.log(i);
}

for (i = 10; i >= 0; i--) {
  console.log("Oh hey there, Nelson!");
}

let name = "Mallory";

for (let j = 0; j < name.length; j++) {
  console.log(j);
  console.log(name[j]);
}

// FOR IN - These loops are great for iterating over objects (enumerable properties).
let student = {
  name: "Michael", //0
  awesome: true, //1
  degree: "Javascript", //2
  week: 3, //3
};

for (tomato in student) {
  console.log(tomato); //OUTPUT: name awesome degree week
  console.log(student[tomato]); //OUTPUT: Michael, true, Javascript, 3
}

let catArray = [
  "tabby", //0
  "calico", //1
  "bengal", //2
  "junkyard cat", //3
  "siamese", //4
  "maine coon", //5
  "hairless", //6
];

for (cat in catArray) {
  console.log(cat);
  console.log(catArray[cat]);
}

// FOR OF - great for iterating over arrays. They will iterate over the values of an iterable object (array).
let catArray2 = [
  "tom cat",
  "tiger",
  "shorthair",
  "persian",
  "catdog",
  "serbal",
];
for (cat of catArray2) {
  console.log(cat, "says meow");
}

//WILL NOT RUN BECAUSE OBJECTS ARE NOT ARRAYS AND ARE NOT ITERABLE.
let student2 = {
  name: "David",
  awesome: true,
  language: "Spanish",
  hobbies: "music",
};

for (item of student2) {
  console.log(item);
}
