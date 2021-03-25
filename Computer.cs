using System;

namespace OOP.Exercise {
    
    public class Computer : Product, Brand {

        public string Description {get; set;}
        public string Model {get; set;}
        public int Price {get; set;}

        public Computer() {
            Description = "a professional laptop with a 13.30-inch display";
            Price = 1000;
            Model = "Spectre x360";
            Manufacturer_id = "103alp";
        }

        public string showDetails() {
            return "This computer's model is "+ Model +" "+ Description +". It has a cost of "+ Price +" $us.";
        }

        public void Category() {
            
        }

        public override void Design() {
            Console.WriteLine($"The design id is {Manufacturer_id}");
        }

    }
}