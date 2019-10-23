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
    public partial class ShowReciptInformationForm : Form
    {
        private readonly frmMainForm mainForm;

        public ShowReciptInformationForm(frmMainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FillInformation();
        }
        private void FillInformation()
        {
            var recipe = mainForm.GetRecipeFromlstBox();
            tBoxTitle.Text = recipe.Title;
            richTextDescription.Text = recipe.Decription;
            richTextIngrediens.Text = recipe.Ingredients;
            var category = new Category(recipe.CategoryId);            
            tBoxCategoryDescription.Text = category.CategoryDescription;
        }
    }
}
