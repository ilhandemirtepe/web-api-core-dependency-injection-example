using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTest.Models;
using MyTest.MyTestBusinessLayer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {

        private IRecipeBusinessLayer _recipeBusinessLayer;

        public RecipesController(IRecipeBusinessLayer recipeBusinessLayer)
        {
            _recipeBusinessLayer = recipeBusinessLayer;
        }

        /// <summary>
        ///1.soru Bir tane Recipes Getir
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        [Route("GetRecipes")]
         public Query GetRecipes()
        {
            return _recipeBusinessLayer.BusinessQuery();
        }
      

        /// <summary>
        ///2.Soru Obje içinden kategorileri getir.
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        [Route("FilterCategories")]

        public Object FilterCategories()
        {
            var item= _recipeBusinessLayer.GetFilterCategory();
            JArray output = JArray.Parse(JsonConvert.SerializeObject(item));
            //var s = new JsonConvert.SerializeObject(item);

            return Ok(output);
           

        }
        /// <summary>
        /// 3.soru yani  mobil obje olarak data gönderecek.Ben de Datayı DB ye kaydedeceğim.Dependency Injection kullanarak
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Add")]

        public Query Add([FromBody]Query query)
        {

            return _recipeBusinessLayer.InsertBusinessQuery(query);

        }





    }
}