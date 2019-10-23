namespace InlamningsUppgift2._0
{
    partial class frmMainForm
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
            this.cbBoxCatagory = new System.Windows.Forms.ComboBox();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelCategoryComboBox = new System.Windows.Forms.Label();
            this.lstRecipeTitles = new System.Windows.Forms.ListBox();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.btnShowRecipeDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBoxCatagory
            // 
            this.cbBoxCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCatagory.FormattingEnabled = true;
            this.cbBoxCatagory.Location = new System.Drawing.Point(98, 30);
            this.cbBoxCatagory.Name = "cbBoxCatagory";
            this.cbBoxCatagory.Size = new System.Drawing.Size(142, 24);
            this.cbBoxCatagory.TabIndex = 0;
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(262, 33);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(271, 22);
            this.tBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(581, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelCategoryComboBox
            // 
            this.labelCategoryComboBox.AutoSize = true;
            this.labelCategoryComboBox.Location = new System.Drawing.Point(31, 37);
            this.labelCategoryComboBox.Name = "labelCategoryComboBox";
            this.labelCategoryComboBox.Size = new System.Drawing.Size(61, 17);
            this.labelCategoryComboBox.TabIndex = 3;
            this.labelCategoryComboBox.Text = "Kategori";
            // 
            // lstRecipeTitles
            // 
            this.lstRecipeTitles.FormattingEnabled = true;
            this.lstRecipeTitles.ItemHeight = 16;
            this.lstRecipeTitles.Location = new System.Drawing.Point(34, 73);
            this.lstRecipeTitles.Name = "lstRecipeTitles";
            this.lstRecipeTitles.Size = new System.Drawing.Size(654, 260);
            this.lstRecipeTitles.TabIndex = 4;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Location = new System.Drawing.Point(373, 369);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(145, 30);
            this.btnNewRecipe.TabIndex = 5;
            this.btnNewRecipe.Text = "Nytt Recept";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(198, 369);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(154, 30);
            this.btnUpdateRecipe.TabIndex = 6;
            this.btnUpdateRecipe.Text = "Uppdatera Recept";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            this.btnUpdateRecipe.Click += new System.EventHandler(this.btnUpdateRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Location = new System.Drawing.Point(550, 369);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(138, 30);
            this.btnDeleteRecipe.TabIndex = 7;
            this.btnDeleteRecipe.Text = "Ta bort Recept";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // btnShowRecipeDetails
            // 
            this.btnShowRecipeDetails.Location = new System.Drawing.Point(28, 369);
            this.btnShowRecipeDetails.Name = "btnShowRecipeDetails";
            this.btnShowRecipeDetails.Size = new System.Drawing.Size(145, 30);
            this.btnShowRecipeDetails.TabIndex = 8;
            this.btnShowRecipeDetails.Text = "Visa Recept";
            this.btnShowRecipeDetails.UseVisualStyleBackColor = true;
            this.btnShowRecipeDetails.Click += new System.EventHandler(this.btnShowRecipeDetails_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.btnShowRecipeDetails);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.btnNewRecipe);
            this.Controls.Add(this.lstRecipeTitles);
            this.Controls.Add(this.labelCategoryComboBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.cbBoxCatagory);
            this.Name = "frmMainForm";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxCatagory;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelCategoryComboBox;
        private System.Windows.Forms.ListBox lstRecipeTitles;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.Button btnShowRecipeDetails;
    }
}

