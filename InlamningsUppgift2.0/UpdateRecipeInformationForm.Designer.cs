namespace InlamningsUppgift2._0
{
    partial class UpdateRecipeInformationForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelIgrediens = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.cBoxCategoryDescription = new System.Windows.Forms.ComboBox();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(24, 29);
            this.tBoxTitle.MaxLength = 50;
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(517, 22);
            this.tBoxTitle.TabIndex = 0;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(24, 88);
            this.richTextDescription.MaxLength = 1000;
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(517, 96);
            this.richTextDescription.TabIndex = 1;
            this.richTextDescription.Text = "";
            // 
            // richTextIngrediens
            // 
            this.richTextIngrediens.Location = new System.Drawing.Point(24, 223);
            this.richTextIngrediens.MaxLength = 1000;
            this.richTextIngrediens.Name = "richTextIngrediens";
            this.richTextIngrediens.Size = new System.Drawing.Size(517, 96);
            this.richTextIngrediens.TabIndex = 2;
            this.richTextIngrediens.Text = "";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(21, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 17);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Titel (max 50 bokstäver)";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(21, 68);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(222, 17);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Beskrivning (max 1000 bokstäver)";
            // 
            // labelIgrediens
            // 
            this.labelIgrediens.AutoSize = true;
            this.labelIgrediens.Location = new System.Drawing.Point(21, 203);
            this.labelIgrediens.Name = "labelIgrediens";
            this.labelIgrediens.Size = new System.Drawing.Size(228, 17);
            this.labelIgrediens.TabIndex = 6;
            this.labelIgrediens.Text = "Ingredienser (max 1000 bokstäver)";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(21, 335);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(61, 17);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Kategori";
            // 
            // cBoxCategoryDescription
            // 
            this.cBoxCategoryDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategoryDescription.FormattingEnabled = true;
            this.cBoxCategoryDescription.Location = new System.Drawing.Point(24, 355);
            this.cBoxCategoryDescription.Name = "cBoxCategoryDescription";
            this.cBoxCategoryDescription.Size = new System.Drawing.Size(517, 24);
            this.cBoxCategoryDescription.TabIndex = 8;
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(174, 396);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(201, 34);
            this.btnUpdateRecipe.TabIndex = 9;
            this.btnUpdateRecipe.Text = "Uppdatera Recept";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // UpdateRecipeInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 452);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.cBoxCategoryDescription);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelIgrediens);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.richTextIngrediens);
            this.Controls.Add(this.richTextDescription);
            this.Controls.Add(this.tBoxTitle);
            this.Name = "UpdateRecipeInformationForm";
            this.Text = "Uppdatera Recept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.RichTextBox richTextIngrediens;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelIgrediens;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox cBoxCategoryDescription;
        private System.Windows.Forms.Button btnUpdateRecipe;
    }
}