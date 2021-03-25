using System;

namespace OOP.Exercise {

    class Program {

        static void Main(string[] args) {
            
            Computer laptop = new Computer();

            Console.WriteLine(laptop.showDetails());
            laptop.Design();

            Brand brand=new Computer();

            Console.WriteLine(brand.Contact());
        }
    }
}
