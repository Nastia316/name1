using System;

namespace inherit_class
{
    public class Animal
    {
        protected string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {

            string animalType = GetType().Name.ToLower();
            Console.WriteLine($"The {animalType} {Name} eats food");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks: Woof woof!");
        }
        public void WigTail()
        {
            Console.WriteLine($"{Name} wigs its tail");
        }
        public void PlayBall()
        {
            int a = new Random().Next(1, 10);
            if (a > 3)
            {
                Console.WriteLine($"You fetched a ball. {Name} got it back"); ;
            }
            else
            {
                Console.WriteLine($"You fetched a ball. {Name} lost it"); ;
            }
        }
    }

    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
        public void Hiss()
        {
            Console.WriteLine($"{Name} is angry, it hisses and scratches");
        }
        public void Pet()
        {
            Console.WriteLine($"{Name} wats you to pet it");
        }

    }
    public class Fish : Animal
    {
        public Fish(string name) : base(name) { }

        public void Sound()
        {
            Console.WriteLine($"{Name} doesn't make any sound; it's a fish");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} swims in circles");
        }
        public void Jump()
        {
            Console.WriteLine($"{Name} jumps out of water and back");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Generic Animal");
            Dog myDog = new Dog("Tim");
            Cat myCat = new Cat("Marusia");
            Fish myFish = new Fish("Darwin");

            myAnimal.Eat();
            myDog.Eat();
            myCat.Eat();
            myFish.Eat();

            myDog.Bark();
            myDog.PlayBall();
            myDog.WigTail();
            myCat.Meow();
            myCat.Hiss();
            myCat.Pet();
            myFish.Jump();
            myFish.Sound();
            myFish.Swim();

            Console.ReadLine();
        }
    }
}