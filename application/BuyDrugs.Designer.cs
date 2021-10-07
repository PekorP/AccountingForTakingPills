
namespace AccountingForTakingPills
{
    partial class BuyDrugs
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
            this.bFindDrugs = new System.Windows.Forms.Button();
            this.bBuyDrugs = new System.Windows.Forms.Button();
            this.tbDrug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bFindDrugs
            // 
            this.bFindDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bFindDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFindDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bFindDrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFindDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bFindDrugs.Location = new System.Drawing.Point(111, 139);
            this.bFindDrugs.Name = "bFindDrugs";
            this.bFindDrugs.Size = new System.Drawing.Size(471, 54);
            this.bFindDrugs.TabIndex = 9;
            this.bFindDrugs.Text = "Поиск лекарств";
            this.bFindDrugs.UseVisualStyleBackColor = false;
            this.bFindDrugs.Click += new System.EventHandler(this.FindDrugs);
            // 
            // bBuyDrugs
            // 
            this.bBuyDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bBuyDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuyDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBuyDrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuyDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBuyDrugs.Location = new System.Drawing.Point(111, 225);
            this.bBuyDrugs.Name = "bBuyDrugs";
            this.bBuyDrugs.Size = new System.Drawing.Size(471, 54);
            this.bBuyDrugs.TabIndex = 10;
            this.bBuyDrugs.Text = "Открыть магазин";
            this.bBuyDrugs.UseVisualStyleBackColor = false;
            this.bBuyDrugs.Click += new System.EventHandler(this.OpenShop);
            // 
            // tbDrug
            // 
            this.tbDrug.BackColor = System.Drawing.Color.PaleGreen;
            this.tbDrug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDrug.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDrug.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbDrug.Location = new System.Drawing.Point(111, 41);
            this.tbDrug.Multiline = true;
            this.tbDrug.Name = "tbDrug";
            this.tbDrug.Size = new System.Drawing.Size(471, 54);
            this.tbDrug.TabIndex = 15;
            // 
            // BuyDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(669, 340);
            this.Controls.Add(this.tbDrug);
            this.Controls.Add(this.bBuyDrugs);
            this.Controls.Add(this.bFindDrugs);
            this.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuyDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка лекарств";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFindDrugs;
        private System.Windows.Forms.Button bBuyDrugs;
        private System.Windows.Forms.TextBox tbDrug;
    }
}