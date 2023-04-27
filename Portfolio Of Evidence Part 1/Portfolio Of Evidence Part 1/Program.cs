using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Of_Evidence_Part_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating List<> variables for the recipe ingredients
            int numberOfIngredients = 0;
            List<String> ingredientNames = new List<String>();
            List<Double> ingredientQuantities = new List<Double>();
            List<String> ingredientUnits = new List<String>();

            // Instantiating List<> variables for the steps of the recipe
            int numberOfSteps = 0;
            List<String> Steps = new List<String>();

            // Temp variable initialised to help combat parsing
            double temp = 0;

            // List<> variable instantiated to help with the scaling feauture
            List<Double> tempQuantity = new List<Double>();

            Console.WriteLine("Welcome!, Please select one of the options that follow.");
            
            // Changing console foreground color to magenta
            Console.ForegroundColor = ConsoleColor.Blue;

            // Changing console background color to blue
            Console.BackgroundColor = ConsoleColor.White;

            // Clear console color (This typically aids in creating the effect of having the entire console a specific color
            Console.Clear();

            // While loop to indefinetely run the program until the user chooses to exit
            while (true)
            {
                // Display menu
                Console.WriteLine("\nPlease choose an option:");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset recipe");
                Console.WriteLine("5. Clear recipe");
                Console.WriteLine("6. Exit");

                String option = Console.ReadLine();

                switch(option) {

                    // Add ingredients to recipe & add steps to recipe
                    case "1":
                        Console.WriteLine("How many ingredients are to be added?");
                        numberOfIngredients = Convert.ToInt32(Console.ReadLine());
                        while(numberOfIngredients > 0)
                        {
                            Console.WriteLine("Please enter the ingredient name");
                            ingredientNames.Add(Console.ReadLine());
                            Console.WriteLine("Please enter the ingredient quantity");
                            
                            temp = double.Parse((Console.ReadLine()));
                            ingredientQuantities.Add(temp);
                            Console.WriteLine("Please enter the ingredient unit");
                            ingredientUnits.Add(Console.ReadLine());
                            numberOfIngredients--;
                        }
                        Console.WriteLine("How many steps are to be added?");
                        numberOfSteps = Convert.ToInt32(Console.ReadLine());
                        while(numberOfSteps > 0)
                        {
                            Console.WriteLine("Please enter a step");
                            Steps.Add(Console.ReadLine());
                            numberOfSteps--;
                        }
                        Console.WriteLine("Details saved successfully");
                        break;

                        // Display recipe
                    case "2":
                        Console.WriteLine("------------------------------\n" +
                            "Name \t Quantity \t Unit\n");
                        for (int i = 0; i < ingredientNames.Count; i++)
                        {
                            Console.WriteLine(ingredientNames[i] + " \t " + ingredientQuantities[i] + " \t\t " + ingredientUnits[i] + "\n");
                        }
                        Console.WriteLine("------------------------------" +
                            "\nIngredient Steps");
                        for (int i = 0; i < Steps.Count; i++)
                        {
                            Console.WriteLine(i +": \t" + Steps[i] + "\n");
                        }
                        break;
                        
                        // Scaling recipe
                        case "3":
                        Console.WriteLine("What is the scale factor for this recipe? Example: (0.5, 1, 1.5)");
                        double scale = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < ingredientQuantities.Count(); i++) { 
                            tempQuantity = ingredientQuantities;
                        tempQuantity[i] = tempQuantity[i] * scale;
                        }
                        Console.WriteLine("Quantities successfully scaled!");
                        break;

                        // Resetting values of recipe to default (Currently not working)
                    case "4":
                        for (int i = 0; i < ingredientQuantities.Count(); i++)
                        {
                            tempQuantity = ingredientQuantities;

                        }
                        Console.WriteLine("Recipe scaling reset to original values!");
                        break;

                        // Clear all values of the recipe
                    case "5":
                        ingredientNames.Clear();
                        ingredientQuantities.Clear();
                        ingredientUnits.Clear();
                        Steps.Clear();
                        numberOfIngredients = 0;
                        numberOfSteps = 0;
                        break;

                        // Exit application
                    case "6":
                        System.Environment.Exit(0);
                        break;

                }


            }



               /*
                            Instantiating ArrayList objects
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
