using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamningsUppgift2._0
{
    public class Category
    {

        public int CategoryId { get; private set; }
        public string CategoryDescription { get; private set; }
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();

        public Category(int categoryId, string categoryDescription)
        {
            CategoryId = categoryId;
            CategoryDescription = categoryDescription;
        }
        public Category(string categoryDescription)
        {
            CategoryDescription = categoryDescription;
            var dbh = new DBhelperGetData();
            CategoryId = dbh.SetCategoryId(CategoryDescription);
        }
        public Category(int categoryId)
        {
            CategoryId = categoryId;
            var dbh = new DBhelperGetData();
            CategoryDescription = dbh.SetCategoryDescription(CategoryId);
        }
        public Category()
        {

        }
        public List<Recipe> GetRecipeWithTitleSearch(string title)
        {
            var dbh = new DBhelperGetData();
            Recipes = dbh.GetRecipeWithTitleSearch(title);
            return Recipes;
        }
        public List<Recipe> GetRecipeWithTitleSearchAndCategory(string title)
        {
            var dbh = new DBhelperGetData();
            Recipes = dbh.GetRecipeWithTitleAndCategorySearch(title,CategoryDescription);
            return Recipes;
        }        
    }    
}
