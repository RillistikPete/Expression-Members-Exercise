using System;
using System.Collections.Generic;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2. Create some instances of your class in the Main method and invoke their methods.

            // Bug mantis = new Bug(string name, string species, List<string> predators, List<string> prey)
            Bug mantis = new Bug("Manty", "Carolina Mantis", new List<string>(){"Condor", "Lizard", "Scorpion", "Children"}, new List<string> {"Other Mantises", "Children", "Roaches", "Moths", "Mosquitos"});

            
            
            Console.WriteLine(mantis.Eat("grass"));     // Manty is still hungry.
            Console.WriteLine(mantis.Eat("Children"));  // Manty ate the Children.
            Console.WriteLine(mantis.PredatorList());   // Condor,Lizard,Scorpion,Children
            Console.WriteLine(mantis.PreyList());       // Other Matnises, Children, Roaches, Moths, Mosquitos

        }
    }
    public class Bug
    {

                /*
                    You can declare a typed public property, make it read-only,
                    and initialize it with a default value all on the same
                    line of code in C#. Readonly properties can be set in the
                    class' constructors, but not by external code.
                */
                public string Name { get; } = "";
                public string Species { get; } = "";
                public ICollection<string> Predators { get; } = new List<string>();
                public ICollection<string> Prey { get; } = new List<string>();

                // Convert this readonly property to an expression member

                //  called a readonly bc there's no 'set' 

                // public string FormalName
                // {
                //     get
                //     {
                //         return $"{this.Name} the {this.Species}";
                //     }
                // }

                public string FormalName
                {
                    get => $"{this.Name} the {this.Species}";
                }
                


                // Class constructor -- when you pass in things, it will set them to the lists

                public Bug(string name, string species, List<string> predators, List<string> prey)
                {
                    this.Name = name;
                    this.Species = species;
                    this.Predators = predators;
                    this.Prey = prey;
                }

                // Convert this method to an expression member

                // public string PreyList()
                // {
                //     var commaDelimitedPrey = string.Join(",", this.Prey);
                //     return commaDelimitedPrey;
                // }

                //Converted:
                public string PreyList() => string.Join(",", this.Prey);

                // Convert this method to an expression member

                // public string PredatorList()
                // {
                //     var commaDelimitedPredators = string.Join(",", this.Predators);
                //     return commaDelimitedPredators;
                // }

                //Converted:
                public string PredatorList() => string.Join(",", this.Predators);


                // Convert this to expression method (hint: use a C# ternary)

                // public string Eat(string food)
                // {
                //     if (this.Prey.Contains(food))
                //     {
                //         return $"{this.Name} ate the {food}.";
                //     } else {
                //         return $"{this.Name} is still hungry.";
                //     }
                // }

                //Converted:
                public string Eat(string food) => this.Prey.Contains(food) ? $"{this.Name} ate the {food}." : $"{this.Name} is still hungry.";
    }
}
