
namespace AccountingForTakingPills
{
    partial class AddDrugInDB
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbAddDrug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAddDrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(218, 141);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(394, 24);
            this.cbCategory.TabIndex = 45;
            // 
            // tbAddDrug
            // 
            this.tbAddDrug.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddDrug.Location = new System.Drawing.Point(216, 39);
            this.tbAddDrug.Multiline = true;
            this.tbAddDrug.Name = "tbAddDrug";
            this.tbAddDrug.Size = new System.Drawing.Size(396, 42);
            this.tbAddDrug.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 33);
            this.label2.TabIndex = 47;
            this.label2.Text = "Категория";
            // 
            // bAddDrug
            // 
            this.bAddDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bAddDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddDrug.Location = new System.Drawing.Point(216, 291);
            this.bAddDrug.Name = "bAddDrug";
            this.bAddDrug.Size = new System.Drawing.Size(396, 54);
            this.bAddDrug.TabIndex = 48;
            this.bAddDrug.Text = "Добавить лекарство";
            this.bAddDrug.UseVisualStyleBackColor = false;
            this.bAddDrug.Click += new System.EventHandler(this.bAddDrug_Click);
            // 
            // AddDrugInDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(697, 374);
            this.Controls.Add(this.bAddDrug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbAddDrug);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Name = "AddDrugInDB";
            this.Text = "Добавление лекарства в систему";
            this.Load += new System.EventHandler(this.AddDrugInDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbAddDrug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAddDrug;
    }
}