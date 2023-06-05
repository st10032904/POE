using Portfolio_Of_Evidence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Of_Evidence_Part_1.Properties
{
    internal class recipeClass
    {
        public string recipeName { get; set; }
        public List<ingredientClass> recipeIngredients { get; set; }
        public List<String> ingredientSteps { get; set; }
    
    public recipeClass()
    {
            recipeIngredients = new List<ingredientClass> ();
            ingredientSteps = new List<String> ();
    }
}
}
