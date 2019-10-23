using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlamningsUppgift2._0
{
    public class DBhelperUpdateDelete : DBhelperGetData
    {
        public void DBNewRecipe(Recipe recipe)
        {

            string sql = $"INSERT INTO Recept(titel,beskrivning,ingredienser,kategoriID) values (@TITLE,@DESCRIPTION,@INGREDIENS,@CATAGORYID)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TITLE", recipe.Title);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", recipe.Decription);
                    cmd.Parameters.AddWithValue("@INGREDIENS", recipe.Ingredients);
                    cmd.Parameters.AddWithValue("@CATAGORYID", Convert.ToInt32(recipe.CategoryId));
                    cmd.ExecuteNonQuery();
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
        public void DBDeleteRecipe(Recipe recipe)
        {
            string sql = $"DELETE FROM Recept where titel = @RECIPT";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue($"@RECIPT", recipe.Title);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
        public void UpdateDBwithRecipe(Recipe recipe)
        {
            string sql = $"UPDATE Recept SET Titel = @TITLE,Beskrivning = @DESCRIPTION,Ingredienser = @INGREDIENS, KategoriID = @CATAGORYID WHERE receptID = @RECIPTID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TITLE", recipe.Title);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", recipe.Decription);
                    cmd.Parameters.AddWithValue("@INGREDIENS", recipe.Ingredients);
                    cmd.Parameters.AddWithValue("@CATAGORYID", Convert.ToInt32(recipe.CategoryId));
                    cmd.Parameters.AddWithValue("@RECIPTID", Convert.ToInt32(recipe.RecipeId));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
    }
}
