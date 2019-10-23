using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlamningsUppgift2._0
{
    public partial class frmMainForm : Form
    {       
        public frmMainForm()
        {
            InitializeComponent();
            GetCategory();
        }
        private void GetCategory()
        {
            var dbmDetData = new DBhelperGetData();
            var listCategorys = dbmDetData.GetKategorier();
            cbBoxCatagory.Items.Add("Ingen");
            foreach (var category in listCategorys)
            {
                cbBoxCatagory.Items.Add(category.CategoryDescription);
            }
        }
        public Recipe GetRecipeFromlstBox()
        {
            
            var dbmGetData = new DBhelperGetData();
            return dbmGetData.GetRecipe(lstRecipeTitles.SelectedItem.ToString());
            
            
        }
        public void UpdateRecipe(string title, string description,string ingrediens, int CategoryId)
        {
            
            var recipe = GetRecipeFromlstBox();
            var updatedRecipe = new Recipe(recipe.RecipeId, title, description, ingrediens, CategoryId);
            var dbhUpdate = new DBhelperUpdateDelete();
            dbhUpdate.UpdateDBwithRecipe(updatedRecipe);
              
        }
        public void CreateRecipe(string title, string description, string ingrediens, string categoryDescription)
        {
            var category = new Category(categoryDescription);
            var newRecipe = new Recipe(title, description, ingrediens, category.CategoryId);
            var dbhUpdate = new DBhelperUpdateDelete();
            dbhUpdate.DBNewRecipe(newRecipe);
        }

        public void FilllstBoxTitle()
        {
            lstRecipeTitles.Items.Clear();
            if (cbBoxCatagory.SelectedIndex <= -1 || cbBoxCatagory.Text == "Ingen")
            {
                var getRecipes = new Category();
                var listRecipes = getRecipes.GetRecipeWithTitleSearch(tBoxSearch.Text);
                foreach (var recipe in listRecipes)
                {
                    lstRecipeTitles.Items.Add(recipe.Title);
                }
            }
            else if (cbBoxCatagory.SelectedIndex > -1)
            {
                var getRecipes = new Category(cbBoxCatagory.Text);
                var listRecipes = getRecipes.GetRecipeWithTitleSearchAndCategory(tBoxSearch.Text);
                foreach (var recipe in listRecipes)
                {
                    lstRecipeTitles.Items.Add(recipe.Title);
                }
            }
        }
        private void DeleteRecipe()
        {
            var recipe = GetRecipeFromlstBox();
            var dbhDelete = new DBhelperUpdateDelete();
            dbhDelete.DBDeleteRecipe(recipe);
            MessageBox.Show("Recept Borttaget");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilllstBoxTitle();
        }       
        
        private void btnShowRecipeDetails_Click(object sender, EventArgs e)
        {
            if (lstRecipeTitles.SelectedIndex > -1)
            {
                using (var subform = new ShowReciptInformationForm(this))
                {
                    subform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Du Måste välja ett recept");
            }
            
        }
       

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipeTitles.SelectedIndex > -1)
            {
                using (var subform = new UpdateRecipeInformationForm(this))
                {
                    subform.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Du Måste välja ett recept");
            }
            
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            using (var subform = new CreateNewRecipeForm(this))
            {
                subform.ShowDialog();
            }

        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (lstRecipeTitles.SelectedIndex > -1)
            {
                DeleteRecipe();
                FilllstBoxTitle();
            }
            else
            {
                MessageBox.Show("Du Måste välja ett recept");
            }
            
        }
    }
}
