using System;

namespace Project2
{

    class Program
    {
        static void Main(string[] args)
        {
            var recepie = new Recepie("Pepperoni-Mushroom Pizza", 13);
            Console.WriteLine($"Okay Everone, now we are about to make our favorite {recepie.Name} in {recepie.NumOfSlices} slices");
            Console.WriteLine("");
            
            Console.WriteLine($"First of all we will need following ingredients: ");
            Console.WriteLine("");

            foreach (var item in recepie.Ingredients)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            string[] steps = {"1-step", "2-step", "3-step", "4-step", "5-step"};
            Console.WriteLine("Now go through all of the steps by typing each of them on the console: ");
            Console.WriteLine("");
            foreach (var step in steps)
            {
                Console.WriteLine(step);
            }
            string stepter = Console.ReadLine();
            switch (stepter)
            {
                case "1-step":
                    Console.WriteLine("1. Preheat the Oven:\r\nPreheat your oven according to the instructions on the pizza dough package.");
                    break;
                case "2-step":
                    Console.WriteLine("2. Roll Out the Dough:\r\nRoll out the store-bought pizza dough on a lightly floured surface to your desired thickness.");
                    break;
                case "3-step":
                    Console.WriteLine("3. Assemble the Pizza:\r\nPlace the rolled-out dough on a pizza stone or baking sheet. Spread pizza sauce evenly over the dough, leaving a small border. Sprinkle shredded mozzarella cheese over the sauce and add your favorite toppings.");
                    break;
                case "4-step":
                    Console.WriteLine("4. Bake the Pizza:\r\nFollow the baking instructions on the pizza dough package, typically around 12-15 minutes or until the crust is golden and the cheese is melted and bubbly.");
                    break;
                case "5-step":
                    Console.WriteLine("5. Serve and Enjoy:\r\nAllow the pizza to cool for a few minutes, then slice and serve. Enjoy your quick and easy homemade pizza!");
                    break;
            }
        }  
    }
}
