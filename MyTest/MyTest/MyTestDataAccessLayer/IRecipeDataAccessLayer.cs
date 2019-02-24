using MyTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.MyTestDataAccessLayer
{
   public  interface IRecipeDataAccessLayer
    {
        Query AddData(Query query);
        List<string> GetFilterCategory();
        Query DataAcessQuery();
    }
}
