
class Person {
    //feild 
    name: string;
    age: number;
    //constructor 
    constructor(name: string, age:number){
        this.name = name;
        this.age = age;
    }
    //method 
    greeet(){
        console.log(`hello my name is ${this.name} and i am from sakri and my age ${this.age}`);
    }
}
let person1 = new Person("najim",24);
person1.greeet(); //hello my name is najim and i am from sakri and my age 24

// class Person {
//     // Fields
//     name: string;
//     age: number;

//     // Constructor
//     constructor(name: string, age: number) {
//         this.name = name;
//         this.age = age;
//     }
// }

class MathUtil {
    //static property 
    static PI: number = 3.14

    //statac method 
    static clculatecercumface( diameter: number ): number{
        return this.PI * diameter;
    }
}

console.log(MathUtil.PI);
console.log(MathUtil.clculatecercumface(10));

abstract class animal {
    abstract makesound(): void; //abstrack method 

    move(): void {
        console.log("Moving ");
    }
}

class Dog extends animal {
    makesound(): void {
        console.log("Bark");
    }
}

let dog = new Dog();

dog.makesound();
dog.move();