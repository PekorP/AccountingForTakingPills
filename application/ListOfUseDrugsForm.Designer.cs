
namespace AccountingForTakingPills
{
    partial class ListOfUseDrugsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDrugs = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.bUseDrug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbDrugs
            // 
            this.lbDrugs.FormattingEnabled = true;
            this.lbDrugs.ItemHeight = 16;
            this.lbDrugs.Location = new System.Drawing.Point(421, 270);
            this.lbDrugs.Name = "lbDrugs";
            this.lbDrugs.Size = new System.Drawing.Size(372, 212);
            this.lbDrugs.TabIndex = 1;
            this.lbDrugs.SelectedIndexChanged += new System.EventHandler(this.lbDrugs_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(50, 286);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // bUseDrug
            // 
            this.bUseDrug.BackColor = System.Drawing.Color.SlateGray;
            this.bUseDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUseDrug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUseDrug.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUseDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUseDrug.Location = new System.Drawing.Point(421, 499);
            this.bUseDrug.Name = "bUseDrug";
            this.bUseDrug.Size = new System.Drawing.Size(372, 74);
            this.bUseDrug.TabIndex = 22;
            this.bUseDrug.Text = "Принять";
            this.bUseDrug.UseVisualStyleBackColor = false;
            this.bUseDrug.Click += new System.EventHandler(this.UseDrug);
            // 
            // ListOfUseDrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(835, 619);
            this.Controls.Add(this.bUseDrug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbDrugs);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListOfUseDrugsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт приёма лекарств";
            this.Load += new System.EventHandler(this.ListOfUseDrugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbDrugs;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bUseDrug;
    }
}