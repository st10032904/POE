using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Of_Evidence_Part_1
{
    
    internal class Steps
    {
        private int number;
        private List<String> recipeSteps;
        public Steps(int numberOfSteps, List<String> Steps)
        {
            number = numberOfSteps;
            recipeSteps = Steps;
        }
        public void setNumberOfSteps(int steps)
        {
            number = steps;
        }
        public void setRecipeSteps(List<String> Steps)
        {
            recipeSteps = Steps;
        }
        public int getNumberOfSteps()
        {
            return number;
        }
        public List<String> getRecipeSteps()
        {
            return recipeSteps;
        }
        public String ToString()
        {
            String output = "";
            for (int i = 0; i < recipeSteps.Count; i++)
            {
                output = output + recipeSteps[i].ToString;
            }
            return output;

        }
        }
    }
    

