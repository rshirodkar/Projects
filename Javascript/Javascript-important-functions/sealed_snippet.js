const objStore = Object.seal({
    one:1,
    two:2,
    three:3
});

// used for knowing about the seal status of the object;
console.log(Object.isSealed(objStore));  // output : true
objStore.four = 4 // trying to add => not allowed
objStore.one = 11 // trying to update => allowed
delete objStore.two // trying to delete => not allowed

console.log("ObjStore: ", objStore); // output: ObjStore:  { one: 11, two: 2, three: 3 }
