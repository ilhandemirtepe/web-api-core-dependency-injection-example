using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTest.Models
{
    public class Query
    {
        public int Results { get; set; }
        public int Total { get; set; }
        public List<Recipe> Recipes { get; set; }

       
    }
}