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
    public partial class CreateNewRecipeForm : Form
    {
        private readonly frmMainForm mainForm;

        public CreateNewRecipeForm(frmMainForm mainForm)
        {
            InitializeComponent();
            FillComboBox();
            this.mainForm = mainForm;
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
        private bool CheckIfTitleExist(string title)
        {
            var dbmGetData = new DBhelperGetData();
            var recipe = dbmGetData.GetRecipe(title,"new");
            if(recipe == null)
            {
                return false;
            }
            return true;
        }

        
        private void btnCreateNewRecipe_Click(object sender, EventArgs e)
        {
            if(CheckIfTitleExist(tBoxTitle.Text))
            {
                if (tBoxTitle.Text.Length >= 1 && richTextDescription.Text.Length >= 1 && richTextIngrediens.Text.Length >= 1 && cBoxCategoryDescription.SelectedIndex > -1)
                {
                    mainForm.CreateRecipe(tBoxTitle.Text, richTextDescription.Text, richTextIngrediens.Text, cBoxCategoryDescription.Text);
                    MessageBox.Show("Receptet är skapat!");
                    mainForm.FilllstBoxTitle();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Du måste fylla varje fält");
                }
            }
            else
            {
                MessageBox.Show("Titeln finns redan");
            }      
        }
    }
}
