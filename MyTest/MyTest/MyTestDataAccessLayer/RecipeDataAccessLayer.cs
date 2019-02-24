using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MyTest.MyTestDataAccessLayer
{
    public class RecipeDataAccessLayer : IRecipeDataAccessLayer
    {
        public Query AddData(Query query)
        {
            //insert data DB
            return query;
        }

        public Query DataAcessQuery()
        {
            string json = @"{
'results': 1,
'total': 90,
'recipes': [ {
'title': '30 Minute Chili',
'categories': [
'Main dish',
'Chili'
],
'ingredients': [ {
'amount': {
'quantity': '1',
'unit': 'pound' },
'name': 'Ground chuck or lean ground; beef' }, {
'amount': {
'quantity': '1',
'unit': '' },
'name': 'Onion; large, chopped' }, {
'amount': {
'quantity': '1',
'unit': 'can' },
'name': 'Kidney beans; (12 oz)' }, {
'amount': {
'quantity': '1',
'unit': 'can' },
'name': 'Tomato soup; undiluted' }, {
'amount': {
'quantity': '1',
'unit': 'teaspoon' },
'name': 'Salt' }, {
'amount': {
'quantity': '1',
'unit': 'tablespoon' },
'name': 'Chili powder; (or to taste)' }, {
'amount': {
'quantity': '',
'unit': '' },
'name': 'Hot pepper sauce; to taste' }
],
'directions': {
'step': ' Brown the meat in a little butter and cook until the meat is brown -- about\n 10 minutes. Add all other ingredients and let simmer for 30 minutes. Your\n choice of hot sauce may be added to taste.\n \n Recipe by: MasterCook Archives\n \n Posted to recipelu-digest Volume 01 Number 577 by Rodeo46898\n <Rodeo46898@aol.com> on Jan 22, 1998\n \n' }
}
] } ";

          
            Query deserializedQuery = JsonConvert.DeserializeObject<Query>(json);
            return deserializedQuery;
        }

        public List<string> GetFilterCategory()
        {
            string json = @"{
'results': 1,
'total': 90,
'recipes': [ {
'title': '30 Minute Chili',
'categories': [
'Main dish',
'Chili'
],
'ingredients': [ {
'amount': {
'quantity': '1',
'unit': 'pound' },
'name': 'Ground chuck or lean ground; beef' }, {
'amount': {
'quantity': '1',
'unit': '' },
'name': 'Onion; large, chopped' }, {
'amount': {
'quantity': '1',
'unit': 'can' },
'name': 'Kidney beans; (12 oz)' }, {
'amount': {
'quantity': '1',
'unit': 'can' },
'name': 'Tomato soup; undiluted' }, {
'amount': {
'quantity': '1',
'unit': 'teaspoon' },
'name': 'Salt' }, {
'amount': {
'quantity': '1',
'unit': 'tablespoon' },
'name': 'Chili powder; (or to taste)' }, {
'amount': {
'quantity': '',
'unit': '' },
'name': 'Hot pepper sauce; to taste' }
],
'directions': {
'step': ' Brown the meat in a little butter and cook until the meat is brown -- about\n 10 minutes. Add all other ingredients and let simmer for 30 minutes. Your\n choice of hot sauce may be added to taste.\n \n Recipe by: MasterCook Archives\n \n Posted to recipelu-digest Volume 01 Number 577 by Rodeo46898\n <Rodeo46898@aol.com> on Jan 22, 1998\n \n' }
}
] } ";
            //JObject jObject = JObject.Parse(json);

            Query deserializedQuery = JsonConvert.DeserializeObject<Query>(json);
            var item = deserializedQuery.Recipes[0].Categories;
            
            return item;

            //var items = jObject["recipes"].Children().ToList();

            //List<string> categoryList = new List<string>();
            //foreach (var item in items)
            //{
            //    categoryList.Add(item["categories"].ToString());
            //}

    
            //var result = String.Join(", ", categoryList.ToArray());

            //List<string> stringList = result.Split(',').ToList();
            //return stringList;


        }
    }
}