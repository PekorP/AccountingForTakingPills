
namespace AccountingForTakingPills
{
    partial class EditDrugForm
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
            this.bSaveEdit = new System.Windows.Forms.Button();
            this.tbCountOfUsePerDay = new System.Windows.Forms.TextBox();
            this.tbCountOfDrugsPerUse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lDrugName = new System.Windows.Forms.Label();
            this.calDateOfEnd = new System.Windows.Forms.MonthCalendar();
            this.calDateOfBegin = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lDateOfBegin
            // 
            this.lDateOfBegin.AutoSize = true;
            this.lDateOfBegin.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateOfBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDateOfBegin.Location = new System.Drawing.Point(386, 325);
            this.lDateOfBegin.Name = "lDateOfBegin";
            this.lDateOfBegin.Size = new System.Drawing.Size(85, 42);
            this.lDateOfBegin.TabIndex = 23;
            this.lDateOfBegin.Text = "date";
            // 
            // lDateOfEnd
            // 
            this.lDateOfEnd.AutoSize = true;
            this.lDateOfEnd.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateOfEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDateOfEnd.Location = new System.Drawing.Point(386, 590);
            this.lDateOfEnd.Name = "lDateOfEnd";
            this.lDateOfEnd.Size = new System.Drawing.Size(85, 42);
            this.lDateOfEnd.TabIndex = 22;
            this.lDateOfEnd.Text = "date";
            // 
            // bSaveEdit
            // 
            this.bSaveEdit.BackColor = System.Drawing.Color.SlateGray;
            this.bSaveEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSaveEdit.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaveEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSaveEdit.Location = new System.Drawing.Point(174, 654);
            this.bSaveEdit.Name = "bSaveEdit";
            this.bSaveEdit.Size = new System.Drawing.Size(901, 54);
            this.bSaveEdit.TabIndex = 21;
            this.bSaveEdit.Text = "Сохранить изменения";
            this.bSaveEdit.UseVisualStyleBackColor = false;
            this.bSaveEdit.Click += new System.EventHandler(this.SaveEdit);
            // 
            // tbCountOfUsePerDay
            // 
            this.tbCountOfUsePerDay.BackColor = System.Drawing.Color.PaleGreen;
            this.tbCountOfUsePerDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountOfUsePerDay.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountOfUsePerDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCountOfUsePerDay.Location = new System.Drawing.Point(762, 431);
            this.tbCountOfUsePerDay.Multiline = true;
            this.tbCountOfUsePerDay.Name = "tbCountOfUsePerDay";
            this.tbCountOfUsePerDay.Size = new System.Drawing.Size(217, 48);
            this.tbCountOfUsePerDay.TabIndex = 20;
            this.tbCountOfUsePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountOfUsePerDay_KeyPress);
            // 
            // tbCountOfDrugsPerUse
            // 
            this.tbCountOfDrugsPerUse.BackColor = System.Drawing.Color.PaleGreen;
            this.tbCountOfDrugsPerUse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountOfDrugsPerUse.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountOfDrugsPerUse.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCountOfDrugsPerUse.Location = new System.Drawing.Point(762, 164);
            this.tbCountOfDrugsPerUse.Multiline = true;
            this.tbCountOfDrugsPerUse.Name = "tbCountOfDrugsPerUse";
            this.tbCountOfDrugsPerUse.Size = new System.Drawing.Size(217, 48);
            this.tbCountOfDrugsPerUse.TabIndex = 19;
            this.tbCountOfDrugsPerUse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountOfDrugsPerUse_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(659, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 42);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество приёмов за день:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(632, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество таблеток за приём:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата окончания - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата начала - ";
            // 
            // lDrugName
            // 
            this.lDrugName.AutoSize = true;
            this.lDrugName.Font = new System.Drawing.Font("Kristen ITC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDrugName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lDrugName.Location = new System.Drawing.Point(350, 24);
            this.lDrugName.Name = "lDrugName";
            this.lDrugName.Size = new System.Drawing.Size(326, 68);
            this.lDrugName.TabIndex = 14;
            this.lDrugName.Text = "Название - ";
            // 
            // calDateOfEnd
            // 
            this.calDateOfEnd.Location = new System.Drawing.Point(362, 375);
            this.calDateOfEnd.Margin = new System.Windows.Forms.Padding(8);
            this.calDateOfEnd.Name = "calDateOfEnd";
            this.calDateOfEnd.TabIndex = 13;
            this.calDateOfEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDateOfEnd_DateChanged);
            // 
            // calDateOfBegin
            // 
            this.calDateOfBegin.Location = new System.Drawing.Point(362, 110);
            this.calDateOfBegin.Margin = new System.Windows.Forms.Padding(8);
            this.calDateOfBegin.Name = "calDateOfBegin";
            this.calDateOfBegin.TabIndex = 12;
            this.calDateOfBegin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDateOfBegin_DateChanged);
            // 
            // EditDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1202, 727);
            this.Controls.Add(this.lDateOfBegin);
            this.Controls.Add(this.lDateOfEnd);
            this.Controls.Add(this.bSaveEdit);
            this.Controls.Add(this.tbCountOfUsePerDay);
            this.Controls.Add(this.tbCountOfDrugsPerUse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDrugName);
            this.Controls.Add(this.calDateOfEnd);
            this.Controls.Add(this.calDateOfBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDrugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование лекарства";
            this.Load += new System.EventHandler(this.EditDrugForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDateOfBegin;
        private System.Windows.Forms.Label lDateOfEnd;
        private System.Windows.Forms.Button bSaveEdit;
        private System.Windows.Forms.TextBox tbCountOfUsePerDay;
        private System.Windows.Forms.TextBox tbCountOfDrugsPerUse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDrugName;
        private System.Windows.Forms.MonthCalendar calDateOfEnd;
        private System.Windows.Forms.MonthCalendar calDateOfBegin;
    }
}