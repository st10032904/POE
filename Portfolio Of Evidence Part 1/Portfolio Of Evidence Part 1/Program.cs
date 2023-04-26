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


/*
            // Instantiating ArrayList objects
            ArrayList Ingredient = new ArrayList();
            ArrayList Quantity = new ArrayList();
            ArrayList unitOfMeasurement = new ArrayList();
            ArrayList Steps = new ArrayList();  

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

            Console.WriteLine("How many steps are going to be in this recipe?");
            int numberOfSteps = Convert.ToInt32(Console.ReadLine());

            List<String> newSteps = new List<String>();

            while (numberOfSteps > 0)
            {


                Console.WriteLine("What is the step");
                newSteps.Add(Console.ReadLine());
                numberOfSteps--;

            }
            Steps step = new Steps(numberOfSteps, newSteps);
            /*
            Console.WriteLine("How many steps are going to be in this recipe?");
            int numberOfSteps = Convert.ToInt32(Console.ReadLine());
            while (numberOfSteps > 0) 
            {

                
                Console.WriteLine("What is the step");
                Steps.Add(Console.ReadLine());
                numberOfSteps--;
            
            }
            

            Console.WriteLine("Ingredient \t Quantity \t Unit");
            for (int i = 0; i < Ingredient.Count; i++)
                Console.Write(Ingredient[i] + "\t" + Quantity[i] + "\t" + unitOfMeasurement[i] + "\n");

            Console.WriteLine(Steps.ToString());
                
            
            Console.WriteLine("Steps \n");
            for (int i = 0; i < Steps.Count; i++)
                Console.Write(Steps[i] + "\n"); 
            */
            Console.ReadKey();
        }
    }
}
