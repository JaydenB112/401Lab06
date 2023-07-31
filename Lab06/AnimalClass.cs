using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Lab06
{
    using System;

    public interface IAnimal
    {
        string name { get; set; }
        string color { get; set; }
        int legs { get; set; }
        bool hasWings { get; }
        void MakeSound();
        void DrinkWater();
    }

    public interface IMammal : IAnimal
    {
        bool hasFur { get; set; }
        bool carnivore();
    }

    public interface IBird : IAnimal
    {
        bool canFly { get; set; }
    }

    public abstract class Animal : IAnimal
    {
        public string name { get; set; }
        public string color { get; set; }
        public int legs { get; set; }

        public virtual bool hasWings => false;

        public Animal(string name, string color, int legs)
        {
            this.name = name;
            this.color = color;
            this.legs = legs;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes an animal sound");
        }

        public virtual void DrinkWater()
        {
            Console.WriteLine("Animal gets hydrated YEAAAAA");
        }
    }

    public abstract class Mammal : Animal, IMammal
    {
        public bool hasFur { get; set; } = true;

        public Mammal(string name, string color, int legs, bool hasFur)
            : base(name, color, legs)
        {
            this.hasFur = hasFur;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Mammal makes a generic sound.");
        }

        public override void DrinkWater()
        {
            Console.WriteLine("Mammal drinks water.");
        }

        public virtual bool carnivore()
        {
            return true;
        }
    }

    public abstract class Bird : Animal, IBird
    {
        public bool canFly { get; set; } = true;

        public Bird(string name, string color, bool canFly)
            : base(name, color, 2)
        {
            this.canFly = canFly;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps.");
        }

        public override void DrinkWater()
        {
            Console.WriteLine("Bird drinks water.");
        }

        public override bool hasWings => true;
    }

    public class Reptile : Animal
    {
        public bool slithers { get; set; }

        public Reptile(string name, string color, int legs, bool slithers)
            : base(name, color, legs)
        {
            this.slithers = slithers;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Reptile makes a generic sound.");
        }

        public override void DrinkWater()
        {
            Console.WriteLine("Reptile drinks water.");
        }
    }

    public class Elephant : Mammal
    {
        public int tusks { get; set; }

        public Elephant(string name, string color, int legs, bool hasFur, int tusks)
            : base(name, color, legs, hasFur)
        {
            this.tusks = tusks;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Elephant trumpets.");
        }

        public override void DrinkWater()
        {
            Console.WriteLine("Elephant drinks water.");
        }

        public override bool carnivore()
        {
            return false;
        }
    }

    public class Lion : Mammal
    {
        public bool mane { get; set; }

        public Lion(string name, string color, int legs, bool hasFur, bool mane)
            : base(name, color, legs, hasFur)
        {
            this.mane = mane;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROOOOOOOAR");
        }

        public override void DrinkWater()
        {
            Console.WriteLine("Sip Sip Sip");
        }

        public override bool carnivore()
        {
            return true;
        }
    }

    public class Hawk : Bird
    {
        public Hawk(string name, string color, bool canFly)
            : base(name, color, canFly) { }
    }

    public class Dichotomy
    {
        public static void Main()
        {
            IMammal elephant = new Elephant("Asian Elephant", "Dark Gray", 4, false, 2);
            IMammal lion = new Lion("Simba", "Gold with Red Mane", 4, true, true);
            IBird hawk = new Hawk("Hawk", "Brown", true);
            IAnimal snake = new Reptile("Snake", "Green", 0, true);

            elephant.MakeSound();
            elephant.DrinkWater();
            Console.WriteLine("Name: " + elephant.name + ", Color: " + elephant.color + ", Legs: " + elephant.legs + ", Has Fur: " + elephant.hasFur + ", Tusks: " + ((Elephant)elephant).tusks + ", Carnivore: " + elephant.carnivore());

            Console.WriteLine();

            lion.MakeSound();
            lion.DrinkWater();
        }
    }
}



