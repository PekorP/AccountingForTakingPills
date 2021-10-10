
namespace AccountingForTakingPills
{
    partial class ListOfDrugsForm
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
            this.lbListOfDrugs = new System.Windows.Forms.ListBox();
            this.bAddDrugs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bEditDrug = new System.Windows.Forms.Button();
            this.bDeleteDrug = new System.Windows.Forms.Button();
            this.bShowInfoAboutDrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListOfDrugs
            // 
            this.lbListOfDrugs.FormattingEnabled = true;
            this.lbListOfDrugs.ItemHeight = 18;
            this.lbListOfDrugs.Items.AddRange(new object[] {
            "Название лекарства"});
            this.lbListOfDrugs.Location = new System.Drawing.Point(46, 91);
            this.lbListOfDrugs.Name = "lbListOfDrugs";
            this.lbListOfDrugs.ScrollAlwaysVisible = true;
            this.lbListOfDrugs.Size = new System.Drawing.Size(437, 310);
            this.lbListOfDrugs.TabIndex = 0;
            // 
            // bAddDrugs
            // 
            this.bAddDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bAddDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddDrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddDrugs.Location = new System.Drawing.Point(518, 91);
            this.bAddDrugs.Name = "bAddDrugs";
            this.bAddDrugs.Size = new System.Drawing.Size(595, 54);
            this.bAddDrugs.TabIndex = 7;
            this.bAddDrugs.Text = "Добавить лекарство";
            this.bAddDrugs.UseVisualStyleBackColor = false;
            this.bAddDrugs.Click += new System.EventHandler(this.AddDrugInList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Работа с списком лекарств";
            // 
            // bEditDrug
            // 
            this.bEditDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bEditDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditDrug.Location = new System.Drawing.Point(518, 177);
            this.bEditDrug.Name = "bEditDrug";
            this.bEditDrug.Size = new System.Drawing.Size(595, 54);
            this.bEditDrug.TabIndex = 9;
            this.bEditDrug.Text = "Редактировать лекарство";
            this.bEditDrug.UseVisualStyleBackColor = false;
            this.bEditDrug.Click += new System.EventHandler(this.EditDrug);
            // 
            // bDeleteDrug
            // 
            this.bDeleteDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bDeleteDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDeleteDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDeleteDrug.Location = new System.Drawing.Point(518, 262);
            this.bDeleteDrug.Name = "bDeleteDrug";
            this.bDeleteDrug.Size = new System.Drawing.Size(595, 54);
            this.bDeleteDrug.TabIndex = 10;
            this.bDeleteDrug.Text = "Удалить лекарство из списка";
            this.bDeleteDrug.UseVisualStyleBackColor = false;
            this.bDeleteDrug.Click += new System.EventHandler(this.DeleteDrugFromList);
            // 
            // bShowInfoAboutDrug
            // 
            this.bShowInfoAboutDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bShowInfoAboutDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowInfoAboutDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bShowInfoAboutDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowInfoAboutDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bShowInfoAboutDrug.Location = new System.Drawing.Point(518, 347);
            this.bShowInfoAboutDrug.Name = "bShowInfoAboutDrug";
            this.bShowInfoAboutDrug.Size = new System.Drawing.Size(595, 54);
            this.bShowInfoAboutDrug.TabIndex = 11;
            this.bShowInfoAboutDrug.Text = "Просмотр информации о лекарстве";
            this.bShowInfoAboutDrug.UseVisualStyleBackColor = false;
            this.bShowInfoAboutDrug.Click += new System.EventHandler(this.ShowInfoAboutDrug);
            // 
            // ListOfDrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1163, 481);
            this.Controls.Add(this.bShowInfoAboutDrug);
            this.Controls.Add(this.bDeleteDrug);
            this.Controls.Add(this.bEditDrug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAddDrugs);
            this.Controls.Add(this.lbListOfDrugs);
            this.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListOfDrugsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список лекарств";
            this.Load += new System.EventHandler(this.ListOfDrugsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbListOfDrugs;
        private System.Windows.Forms.Button bAddDrugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEditDrug;
        private System.Windows.Forms.Button bDeleteDrug;
        private System.Windows.Forms.Button bShowInfoAboutDrug;
    }
}