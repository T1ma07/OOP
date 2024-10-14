class Calculator {
    public int Add(int a, int b) {
        Console.WriteLine("2 ints addition");
        return a + b;
    }

    public double Add(double a, double b) {
        Console.WriteLine("2 doubles addition");
        return a + b;
    }

    public int Add(int a, int b, int c) {
        Console.WriteLine("3 int addition");
        return a + b + c;
    }
}

//

abstract class Animal {
    public abstract void MakeSound();
    public void Sleep() {
        Console.WriteLine("Animal is sleeping...");
    }
}

class Cat:Animal {
    public override void MakeSound() {
        Console.WriteLine("Cat meows!!!");
    }
}

class Dog:Animal {
    public override void MakeSound() {
        Console.WriteLine("Dog barks!!!");
    }
}

class Program {

    public static void Main() {
        Animal myCat = new Cat();
        animal myDog = new Dog();

        myDog.MakeSound();
        myDog.Sleep();

        myCat.MakeSound();
        myCat.Sleep();
    }
}