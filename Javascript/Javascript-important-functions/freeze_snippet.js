const someObj = {
    one: 1,
    two: 2,
    three: 3
};

Object.freeze(someObj);

someObj.four = 4;   // add
someObj.one = 22;   // update
delete someObj.two; // delete

// no operations will affect the original object after its "frozen"

console.log("someObj: " , someObj); // output : someObj:  { one: 1, two: 2, three: 3 }