using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTest.Models
{
    public class Recipe
    {
        public  string Title { get; set; }
        public List<string> Categories { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Direction Directions { get; set; }

    }
}