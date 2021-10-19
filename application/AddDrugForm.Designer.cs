
namespace AccountingForTakingPills
{
    partial class AddDrugForm
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
            this.lDateOfBegin = new System.Windows.Forms.Label();
            this.lDateOfEnd = new System.Windows.Forms.Label();
            this.tbCountOfUsePerDay = new System.Windows.Forms.TextBox();
            this.tbCountOfDrugsPerUse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calDateOfEnd = new System.Windows.Forms.MonthCalendar();
            this.calDateOfBegin = new System.Windows.Forms.MonthCalendar();
            this.bAddDrug = new System.Windows.Forms.Button();
            this.tbFindDrug = new System.Windows.Forms.TextBox();
            this.lbListOfDrugs = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lAddedDrug = new System.Windows.Forms.Label();
            this.bAddDrugInDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDateOfBegin
            // 
            this.lDateOfBegin.AutoSize = true;
            this.lDateOfBegin.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateOfBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDateOfBegin.Location = new System.Drawing.Point(342, 319);
            this.lDateOfBegin.Name = "lDateOfBegin";
            this.lDateOfBegin.Size = new System.Drawing.Size(85, 42);
            this.lDateOfBegin.TabIndex = 33;
            this.lDateOfBegin.Text = "date";
            // 
            // lDateOfEnd
            // 
            this.lDateOfEnd.AutoSize = true;
            this.lDateOfEnd.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateOfEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDateOfEnd.Location = new System.Drawing.Point(342, 584);
            this.lDateOfEnd.Name = "lDateOfEnd";
            this.lDateOfEnd.Size = new System.Drawing.Size(85, 42);
            this.lDateOfEnd.TabIndex = 32;
            this.lDateOfEnd.Text = "date";
            // 
            // tbCountOfUsePerDay
            // 
            this.tbCountOfUsePerDay.BackColor = System.Drawing.Color.PaleGreen;
            this.tbCountOfUsePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountOfUsePerDay.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountOfUsePerDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCountOfUsePerDay.Location = new System.Drawing.Point(689, 425);
            this.tbCountOfUsePerDay.Multiline = true;
            this.tbCountOfUsePerDay.Name = "tbCountOfUsePerDay";
            this.tbCountOfUsePerDay.Size = new System.Drawing.Size(217, 48);
            this.tbCountOfUsePerDay.TabIndex = 31;
            this.tbCountOfUsePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountOfUsePerDay_KeyPress);
            // 
            // tbCountOfDrugsPerUse
            // 
            this.tbCountOfDrugsPerUse.BackColor = System.Drawing.Color.PaleGreen;
            this.tbCountOfDrugsPerUse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountOfDrugsPerUse.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountOfDrugsPerUse.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCountOfDrugsPerUse.Location = new System.Drawing.Point(689, 158);
            this.tbCountOfDrugsPerUse.Multiline = true;
            this.tbCountOfDrugsPerUse.Name = "tbCountOfDrugsPerUse";
            this.tbCountOfDrugsPerUse.Size = new System.Drawing.Size(217, 48);
            this.tbCountOfDrugsPerUse.TabIndex = 30;
            this.tbCountOfDrugsPerUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountOfDrugsPerUse_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(586, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 42);
            this.label4.TabIndex = 29;
            this.label4.Text = "Количество приёмов за день:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(586, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 42);
            this.label3.TabIndex = 28;
            this.label3.Text = "Количество таблеток за приём:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 27;
            this.label2.Text = "Дата окончания - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Дата начала - ";
            // 
            // calDateOfEnd
            // 
            this.calDateOfEnd.Location = new System.Drawing.Point(330, 369);
            this.calDateOfEnd.Margin = new System.Windows.Forms.Padding(8);
            this.calDateOfEnd.Name = "calDateOfEnd";
            this.calDateOfEnd.TabIndex = 25;
            this.calDateOfEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDateOfEnd_DateChanged);
            // 
            // calDateOfBegin
            // 
            this.calDateOfBegin.Location = new System.Drawing.Point(330, 104);
            this.calDateOfBegin.Margin = new System.Windows.Forms.Padding(8);
            this.calDateOfBegin.Name = "calDateOfBegin";
            this.calDateOfBegin.TabIndex = 24;
            this.calDateOfBegin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDateOfBegin_DateChanged);
            // 
            // bAddDrug
            // 
            this.bAddDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bAddDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddDrug.Location = new System.Drawing.Point(190, 654);
            this.bAddDrug.Name = "bAddDrug";
            this.bAddDrug.Size = new System.Drawing.Size(901, 54);
            this.bAddDrug.TabIndex = 34;
            this.bAddDrug.Text = "Добавить лекарство";
            this.bAddDrug.UseVisualStyleBackColor = false;
            this.bAddDrug.Click += new System.EventHandler(this.AddDrug);
            // 
            // tbFindDrug
            // 
            this.tbFindDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFindDrug.Location = new System.Drawing.Point(1243, 104);
            this.tbFindDrug.Multiline = true;
            this.tbFindDrug.Name = "tbFindDrug";
            this.tbFindDrug.Size = new System.Drawing.Size(396, 42);
            this.tbFindDrug.TabIndex = 35;
            this.tbFindDrug.TextChanged += new System.EventHandler(this.tbFindDrug_TextChanged);
            // 
            // lbListOfDrugs
            // 
            this.lbListOfDrugs.FormattingEnabled = true;
            this.lbListOfDrugs.ItemHeight = 16;
            this.lbListOfDrugs.Location = new System.Drawing.Point(1243, 168);
            this.lbListOfDrugs.Name = "lbListOfDrugs";
            this.lbListOfDrugs.Size = new System.Drawing.Size(396, 228);
            this.lbListOfDrugs.TabIndex = 36;
            this.lbListOfDrugs.SelectedIndexChanged += new System.EventHandler(this.lbListOfDrugs_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1300, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 28);
            this.label5.TabIndex = 37;
            this.label5.Text = "Не нашли то, что искали?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1238, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 39);
            this.label6.TabIndex = 38;
            this.label6.Text = "Поиск лекарств:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1301, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "Добавьте своё лекарство!";
            // 
            // lAddedDrug
            // 
            this.lAddedDrug.AutoSize = true;
            this.lAddedDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddedDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lAddedDrug.Location = new System.Drawing.Point(323, 24);
            this.lAddedDrug.Name = "lAddedDrug";
            this.lAddedDrug.Size = new System.Drawing.Size(599, 42);
            this.lAddedDrug.TabIndex = 40;
            this.lAddedDrug.Text = "Название добавляемого лекарства -  ";
            // 
            // bAddDrugInDB
            // 
            this.bAddDrugInDB.BackColor = System.Drawing.Color.SlateGray;
            this.bAddDrugInDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddDrugInDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddDrugInDB.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDrugInDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddDrugInDB.Location = new System.Drawing.Point(1243, 491);
            this.bAddDrugInDB.Name = "bAddDrugInDB";
            this.bAddDrugInDB.Size = new System.Drawing.Size(396, 101);
            this.bAddDrugInDB.TabIndex = 42;
            this.bAddDrugInDB.Text = "Добавить лекарство в базу";
            this.bAddDrugInDB.UseVisualStyleBackColor = false;
            this.bAddDrugInDB.Click += new System.EventHandler(this.bAddDrugInDB_Click);
            // 
            // AddDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1669, 720);
            this.Controls.Add(this.bAddDrugInDB);
            this.Controls.Add(this.lAddedDrug);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbListOfDrugs);
            this.Controls.Add(this.tbFindDrug);
            this.Controls.Add(this.bAddDrug);
            this.Controls.Add(this.lDateOfBegin);
            this.Controls.Add(this.lDateOfEnd);
            this.Controls.Add(this.tbCountOfUsePerDay);
            this.Controls.Add(this.tbCountOfDrugsPerUse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calDateOfEnd);
            this.Controls.Add(this.calDateOfBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление лекарства в список";
            this.Load += new System.EventHandler(this.AddDrugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDateOfBegin;
        private System.Windows.Forms.Label lDateOfEnd;
        private System.Windows.Forms.TextBox tbCountOfUsePerDay;
        private System.Windows.Forms.TextBox tbCountOfDrugsPerUse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calDateOfEnd;
        private System.Windows.Forms.MonthCalendar calDateOfBegin;
        private System.Windows.Forms.Button bAddDrug;
        private System.Windows.Forms.TextBox tbFindDrug;
        private System.Windows.Forms.ListBox lbListOfDrugs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lAddedDrug;
        private System.Windows.Forms.Button bAddDrugInDB;
    }
}