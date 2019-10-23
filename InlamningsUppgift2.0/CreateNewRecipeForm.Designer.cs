namespace InlamningsUppgift2._0
{
    partial class CreateNewRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxTitle = new System.Windows.Forms.TextBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.richTextIngrediens = new System.Windows.Forms.RichTextBox();
            this.cBoxCategoryDescription = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelIngrediens = new System.Windows.Forms.Label();
            this.CategoryDescription = new System.Windows.Forms.Label();
            this.btnCreateNewRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(67, 51);
            this.tBoxTitle.MaxLength = 50;
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(527, 22);
            this.tBoxTitle.TabIndex = 0;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(67, 124);
            this.richTextDescription.MaxLength = 1000;
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(527, 111);
            this.richTextDescription.TabIndex = 1;
            this.richTextDescription.Text = "";
            // 
            // richTextIngrediens
            // 
            this.richTextIngrediens.Location = new System.Drawing.Point(67, 286);
            this.richTextIngrediens.MaxLength = 1000;
            this.richTextIngrediens.Name = "richTextIngrediens";
            this.richTextIngrediens.Size = new System.Drawing.Size(527, 96);
            this.richTextIngrediens.TabIndex = 2;
            this.richTextIngrediens.Text = "";
            // 
            // cBoxCategoryDescription
            // 
            this.cBoxCategoryDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoryDescription.FormattingEnabled = true;
            this.cBoxCategoryDescription.Location = new System.Drawing.Point(67, 418);
            this.cBoxCategoryDescription.Name = "cBoxCategoryDescription";
            this.cBoxCategoryDescription.Size = new System.Drawing.Size(527, 24);
            this.cBoxCategoryDescription.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(64, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Titel";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(64, 95);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(81, 17);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Beskrivning";
            // 
            // labelIngrediens
            // 
            this.labelIngrediens.AutoSize = true;
            this.labelIngrediens.Location = new System.Drawing.Point(64, 256);
            this.labelIngrediens.Name = "labelIngrediens";
            this.labelIngrediens.Size = new System.Drawing.Size(87, 17);
            this.labelIngrediens.TabIndex = 6;
            this.labelIngrediens.Text = "Ingredienser";
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.AutoSize = true;
            this.CategoryDescription.Location = new System.Drawing.Point(64, 398);
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Size = new System.Drawing.Size(88, 17);
            this.CategoryDescription.TabIndex = 7;
            this.CategoryDescription.Text = "Välj Kategori";
            // 
            // btnCreateNewRecipe
            // 
            this.btnCreateNewRecipe.Location = new System.Drawing.Point(253, 463);
            this.btnCreateNewRecipe.Name = "btnCreateNewRecipe";
            this.btnCreateNewRecipe.Size = new System.Drawing.Size(148, 47);
            this.btnCreateNewRecipe.TabIndex = 8;
            this.btnCreateNewRecipe.Text = "Skapa Recept";
            this.btnCreateNewRecipe.UseVisualStyleBackColor = true;
            this.btnCreateNewRecipe.Click += new System.EventHandler(this.btnCreateNewRecipe_Click);
            // 
            // CreateNewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 531);
            this.Controls.Add(this.btnCreateNewRecipe);
            this.Controls.Add(this.CategoryDescription);
            this.Controls.Add(this.labelIngrediens);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.cBoxCategoryDescription);
            this.Controls.Add(this.richTextIngrediens);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.tBoxTitle);
            this.Name = "CreateNewRecipeForm";
            this.Text = "CreateNewRecipeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.RichTextBox richTextIngrediens;
        private System.Windows.Forms.ComboBox cBoxCategoryDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelIngrediens;
        private System.Windows.Forms.Label CategoryDescription;
        private System.Windows.Forms.Button btnCreateNewRecipe;
    }
}