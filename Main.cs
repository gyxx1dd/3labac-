using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3labac_
{
    public class Animal
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public double DailyMaintenanceCost { get; set; }

        
        public Animal(double weight, int age, double dailyMaintenanceCost)
        {
            this.Weight = weight;
            this.Age = age;
            this.DailyMaintenanceCost = dailyMaintenanceCost;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Daily Maintenance Cost: {DailyMaintenanceCost}$");
        }
    }

    public class Wolf : Animal
    {
        public string Breed { get; set; }
        public string NaturalHabitat { get; set; }

        public Wolf(double weight, int age, double dailyMaintenanceCost, string breed, string naturalHabitat)
            : base(weight, age, dailyMaintenanceCost)
        {
            Breed = breed;
            NaturalHabitat = naturalHabitat;
        }

        
        public override void DisplayInfo()
        {
            base.DisplayInfo(); 
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Natural Habitat: {NaturalHabitat}");
        }
    }
}
