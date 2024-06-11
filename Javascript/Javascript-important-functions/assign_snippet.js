// demonstrating ASSIGN() method

// declare and initialize 2 objects
const object1 = {one:1, two:2, three:3};
const object2 = {four:4, five:5, size:6};

const result = Object.assign(object1, object2);
console.log("result: ", result); // result:  { one: 1, two: 2, three: 3, four: 4, five: 5, size: 6 }
console.log("object1: ", object1);  // changes to : object1:  { one: 1, two: 2, three: 3, four: 4, five: 5, size: 6 }
console.log("object2: ", object2); // remains same
