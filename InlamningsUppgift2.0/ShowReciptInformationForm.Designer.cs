namespace InlamningsUppgift2._0
{
    partial class ShowReciptInformationForm
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
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.tBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextIngrediens = new System.Windows.Forms.RichTextBox();
            this.labelIngrediens = new System.Windows.Forms.Label();
            this.tBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.labelCategoriDecription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(224, 111);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(485, 96);
            this.richTextDescription.TabIndex = 0;
            this.richTextDescription.Text = "";
            // 
            // tBoxTitle
            // 
            this.tBoxTitle.Location = new System.Drawing.Point(224, 57);
            this.tBoxTitle.Name = "tBoxTitle";
            this.tBoxTitle.Size = new System.Drawing.Size(485, 22);
            this.tBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(74, 57);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Titel";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(74, 114);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 17);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Recept Beskrivning";
            // 
            // richTextIngrediens
            // 
            this.richTextIngrediens.Location = new System.Drawing.Point(224, 232);
            this.richTextIngrediens.Name = "richTextIngrediens";
            this.richTextIngrediens.Size = new System.Drawing.Size(485, 96);
            this.richTextIngrediens.TabIndex = 4;
            this.richTextIngrediens.Text = "";
            // 
            // labelIngrediens
            // 
            this.labelIngrediens.AutoSize = true;
            this.labelIngrediens.Location = new System.Drawing.Point(74, 232);
            this.labelIngrediens.Name = "labelIngrediens";
            this.labelIngrediens.Size = new System.Drawing.Size(87, 17);
            this.labelIngrediens.TabIndex = 5;
            this.labelIngrediens.Text = "Ingredienser";
            // 
            // tBoxCategoryDescription
            // 
            this.tBoxCategoryDescription.Location = new System.Drawing.Point(224, 351);
            this.tBoxCategoryDescription.Name = "tBoxCategoryDescription";
            this.tBoxCategoryDescription.Size = new System.Drawing.Size(485, 22);
            this.tBoxCategoryDescription.TabIndex = 6;
            // 
            // labelCategoriDecription
            // 
            this.labelCategoriDecription.AutoSize = true;
            this.labelCategoriDecription.Location = new System.Drawing.Point(77, 351);
            this.labelCategoriDecription.Name = "labelCategoriDecription";
            this.labelCategoriDecription.Size = new System.Drawing.Size(138, 17);
            this.labelCategoriDecription.TabIndex = 7;
            this.labelCategoriDecription.Text = "Kategori Beskrivning";
            // 
            // ShowReciptInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategoriDecription);
            this.Controls.Add(this.tBoxCategoryDescription);
            this.Controls.Add(this.labelIngrediens);
            this.Controls.Add(this.richTextIngrediens);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tBoxTitle);
            this.Controls.Add(this.richTextDescription);
            this.Name = "ShowReciptInformationForm";
            this.Text = "Recept Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.TextBox tBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextIngrediens;
        private System.Windows.Forms.Label labelIngrediens;
        private System.Windows.Forms.TextBox tBoxCategoryDescription;
        private System.Windows.Forms.Label labelCategoriDecription;
    }
}