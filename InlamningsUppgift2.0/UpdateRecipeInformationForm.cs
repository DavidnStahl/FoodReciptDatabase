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
    public partial class UpdateRecipeInformationForm : Form
    {
        private readonly frmMainForm mainForm;

        public UpdateRecipeInformationForm(frmMainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillComboBox();
            FillInformation();
        }
        private void FillInformation()
        {
            var recipe = mainForm.GetRecipeFromlstBox();
            tBoxTitle.Text = recipe.Title;
            richTextDescription.Text = recipe.Decription;
            richTextIngrediens.Text = recipe.Ingredients;
            var category = new Category(recipe.CategoryId);
            cBoxCategoryDescription.SelectedItem = category.CategoryDescription;
        }
        private void FillComboBox()
        {
            var dbmDetData = new DBhelperGetData();
            var listCategorys = dbmDetData.GetKategorier();
            foreach (var category in listCategorys)
            {
                cBoxCategoryDescription.Items.Add(category.CategoryDescription);
            }
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            if(tBoxTitle.Text.Length >= 1 && richTextDescription.Text.Length >=1 && richTextIngrediens.Text.Length >= 1 && cBoxCategoryDescription.SelectedIndex > -1)
            {
                var getCategoryId = new Category(cBoxCategoryDescription.Text);
                mainForm.UpdateRecipe(tBoxTitle.Text, richTextDescription.Text, richTextIngrediens.Text, getCategoryId.CategoryId);
                MessageBox.Show("Recept Uppdaterat");
                mainForm.FilllstBoxTitle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du måste fylla varje fält");
                FillInformation();
            }

                       
        }
    }
}
