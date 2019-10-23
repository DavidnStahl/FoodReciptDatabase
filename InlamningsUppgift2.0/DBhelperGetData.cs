using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InlamningsUppgift2._0
{
    public class DBhelperGetData
    {
        protected readonly string connectionString;
        public DBhelperGetData()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ToString();

        }
        public List<Category> GetKategorier()
        {
            var listCategory = new List<Category>();
            string sql = $"SELECT KategoriBeskrivning FROM Kategorier";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    var result = cmd.ExecuteReader();

                    while (result.Read())
                    {
                        
                        var category = new Category(((result["KategoriBeskrivning"].ToString())));
                        listCategory.Add(category);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }

            return listCategory;
        }
      
        public string SetCategoryDescription(int categoryId)
        {
            string sql = $"SELECT KategoriBeskrivning FROM Kategorier WHERE KategoriId = @NAME";
            var categoryDescription = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@NAME", categoryId);
                    categoryDescription = cmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            return categoryDescription;
        }
        public int SetCategoryId(string categoryDescription)
        {
            string sql = $"SELECT KategoriID FROM Kategorier WHERE KategoriBeskrivning = @NAME";
            var categoryId = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);                   
                    cmd.Parameters.AddWithValue("@NAME",categoryDescription);
                    categoryId = Convert.ToInt32(cmd.ExecuteScalar());   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            return categoryId;
        }
        public Recipe GetRecipe(string title,string newRecipe = "")
        {
            var Recipe = new Recipe();
            string sql = $"SELECT * FROM Recept where Titel = @NAME";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@NAME", title);
                    

                    SqlDataReader result = cmd.ExecuteReader();

                    
                    while (result.Read())
                    {
                        var recipeIDRecipe = result["receptID"].ToString();
                        var titleRecipe = result["Titel"].ToString();

                        if(titleRecipe == title && newRecipe == "new")
                        {
                            return null;
                        }
                        var descriptionRecipe = result["Beskrivning"].ToString();
                        var ingrediensRecipe = result["Ingredienser"].ToString();
                        var categoryIdRecipe = result["KategoriID"].ToString();
                        Recipe.CreateRecipeWithValues(Convert.ToInt32(recipeIDRecipe), titleRecipe, descriptionRecipe, ingrediensRecipe, Convert.ToInt32(categoryIdRecipe));
                    }
                           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            return Recipe;
        }
        public List<Recipe> GetRecipeWithTitleSearch(string title)
        {
            var listRecipe = new List<Recipe>();
            string sql = $"SELECT * FROM Recept where Titel Like @NAME";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@NAME",title + "%");
                    
                    
                    
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        var recipeIDRecipe = ((result["receptID"].ToString()));
                        var titleRecipe = ((result["Titel"].ToString()));
                        var descriptionRecipe = ((result["Beskrivning"].ToString()));
                        var ingrediensRecipe = ((result["Ingredienser"].ToString()));
                        var categoryIdRecipe = ((result["KategoriID"].ToString()));

                        var recipt = new Recipe(Convert.ToInt32(recipeIDRecipe), titleRecipe, descriptionRecipe, ingrediensRecipe, Convert.ToInt32(categoryIdRecipe));
                        listRecipe.Add(recipt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {                
            }
            return listRecipe;
        }
        public List<Recipe> GetRecipeWithTitleAndCategorySearch(string title, string categoryDescription)
        {
            var listRecipe = new List<Recipe>();
            string sql = $"SELECT * FROM Recept r INNER JOIN Kategorier k ON k.KategoriID = r.KategoriID where Titel like @NAME AND k.KategoriBeskrivning = @DESCRIPTION";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (title.Length == 1)
                    {
                        cmd.Parameters.AddWithValue("@NAME", title + "%");
                        cmd.Parameters.AddWithValue("@DESCRIPTION",categoryDescription);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NAME", "%" + title + "%");
                        cmd.Parameters.AddWithValue("@DESCRIPTION",categoryDescription);
                    }
                    SqlDataReader result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        var recipeIDRecipe = ((result["receptID"].ToString()));
                        var titleRecipe = ((result["Titel"].ToString()));
                        var descriptionRecipe = ((result["Beskrivning"].ToString()));
                        var ingrediensRecipe = ((result["Ingredienser"].ToString()));
                        var categoryIdRecipe = ((result["KategoriID"].ToString()));

                        var recipt = new Recipe(Convert.ToInt32(recipeIDRecipe), titleRecipe, descriptionRecipe, ingrediensRecipe, Convert.ToInt32(categoryIdRecipe));
                        listRecipe.Add(recipt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
            return listRecipe;
        }

    }
}
