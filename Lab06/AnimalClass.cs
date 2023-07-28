using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Net.Http.Headers;

namespace Lab06
{
    public abstract class Animal
    {
        public string name;
        public string color;
        public int legs;

        // Constructor to initialize the fields
        public Animal(string name, string color, int legs)
        {
            this.name = name;
            this.color = color;
            this.legs = legs;
        }
    }

    public abstract class Mammal : Animal
    {
        public bool hasFur;

        public Mammal(string name, string color, int legs, bool hasFur)
            : base(name, color, legs)
        {
            this.hasFur = hasFur;
        }
    }

    public abstract class Bird : Animal
    {
        public bool canFly;

        public Bird(string name, string color, bool canFly)
            : base(name, color, 2)
        {
            this.canFly = canFly;
        }
    }

    public class Reptile : Animal
    {
        public bool slithers;

        public Reptile(string name, string color,int legs, bool  slithers)
            : base(name, color, legs)
        {
            this.slithers = slithers;
        }
    }

    public class Elephant : Mammal
    {
        public int tusks;

        public Elephant(string name, string color, int legs,bool hasfur, int tusks)
            : base(name, color, legs, hasfur)
        {
            this.tusks = tusks;
        }
    }

    public class Lion : Mammal
    {
        public bool mane;
        public Lion(string name, string color, int legs, bool hasfur, bool mane)
            : base(name, color, legs, hasfur)
        {
            this.mane = mane;
        }
    }

    public class Hawk : Bird
    {
        public bool 
    }






    public class Dichotemy
    {
        public static void Main()
        {


            // Creating instances of the Mammal class
            //Mammal Elephant = new Mammal("Elephant", "Gray", 4, true);
            //Mammal Dog = new Mammal("Dog", "Black", 4, true);

            Elephant AsianElephant = new Elephant("Asian Elephant", "Dark Gray", 4, false, 2);
            Lion Simba = new Lion("Simba", "Gold with Red Mane", 4, true, true);


            // Creating instances of the Bird class
           // Bird Sparrow = new Bird("Sparrow", "Brown", true);
           // Bird Penguin = new Bird("Penguin", "Black and White", false);

            // LIZARD OVERLORDS YEEEEEA
            Reptile Komodo = new Reptile("Komodo", "Dark Green",4, false);
            Reptile Mamba = new Reptile("Mamba", "Black",0, true);


            // Printing information about the animals, mammals, and birds
           
           // Console.WriteLine("Name: " + Elephant.name + ", Color: " + Elephant.color + ", Legs: " + Elephant.legs + ", Has Fur: " + Elephant.hasFur);
           // Console.WriteLine("Name: " + Sparrow.name + ", Color: " + Sparrow.color + ", Legs: " + Sparrow.legs + ", Can Fly: " + Sparrow.canFly);
        }
    }
}



