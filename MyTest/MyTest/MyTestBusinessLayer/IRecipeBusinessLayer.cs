using MyTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTest.MyTestBusinessLayer
{
    public interface IRecipeBusinessLayer
    {
        Query InsertBusinessQuery(Query query);

        Query BusinessQuery();

        List<string> GetFilterCategory();
    }
}
