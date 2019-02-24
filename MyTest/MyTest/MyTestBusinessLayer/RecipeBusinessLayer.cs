using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using MyTest.MyTestDataAccessLayer;

namespace MyTest.MyTestBusinessLayer
{
    public class RecipeBusinessLayer : IRecipeBusinessLayer
    {

        IRecipeDataAccessLayer recipeDataAccessLayer;

        public RecipeBusinessLayer(IRecipeDataAccessLayer _recipeDataAccessLayer)
        {
            recipeDataAccessLayer = _recipeDataAccessLayer;
        }



        public Query InsertBusinessQuery(Query query)
        {
            return recipeDataAccessLayer.AddData(query);
        }



        public List<string> GetFilterCategory()
        {
            return recipeDataAccessLayer.GetFilterCategory();
        }

        public Query BusinessQuery()
        {
            return recipeDataAccessLayer.DataAcessQuery();
        }
    }
}
