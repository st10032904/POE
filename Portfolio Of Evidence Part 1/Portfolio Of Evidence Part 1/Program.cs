using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Of_Evidence_Part_1

{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instantiating ArrayList objects
            ArrayList Ingredient = new ArrayList();
            ArrayList Quantity = new ArrayList();
            ArrayList unitOfMeasurement = new ArrayList();

            Console.WriteLine("How many ingredients are going to be in this recipe?");
            int numberOfIngredients = Convert.ToInt32(Console.ReadLine());
            while (numberOfIngredients > 0)
            {
                Console.WriteLine("Please enter the name of the ingredient?");
                String ingredient = Console.ReadLine();
                Ingredient.Add(ingredient);
                Console.WriteLine("Please enter the quantity for this ingredient");
                Double quantity = Convert.ToDouble(Console.ReadLine());
                Quantity.Add(quantity);
                Console.WriteLine("Please enter the unit of measurement for this ingredient");
                String unit = Console.ReadLine();
                unitOfMeasurement.Add(unit);
                numberOfIngredients--;
            }
            Console.ReadKey();
        }
    }
}
