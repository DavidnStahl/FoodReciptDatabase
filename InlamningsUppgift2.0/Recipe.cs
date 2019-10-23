using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsUppgift2._0
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public string Ingredients { get; set; }
        public int CategoryId { get; set; }

        public Recipe(int recipeID,string title, string decription, string ingredients, int categoryId)
        {
            RecipeId = recipeID;
            Title = title;
            Decription = decription;
            Ingredients = ingredients;
            CategoryId = categoryId;
        }
        public Recipe(string title, string decription, string ingredients, int categoryId)
        {
            Title = title;
            Decription = decription;
            Ingredients = ingredients;
            CategoryId = categoryId;
        }
        public Recipe()
        {
        }
        public void CreateRecipeWithValues(int recipeID, string title, string decription, string ingredients, int categoryId)
        {
            RecipeId = recipeID;
            Title = title;
            Decription = decription;
            Ingredients = ingredients;
            CategoryId = categoryId;
        }
        
    }
}
