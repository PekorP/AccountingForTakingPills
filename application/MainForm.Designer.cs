
namespace AccountingForTakingPills
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bListOfDrugs = new System.Windows.Forms.Button();
            this.bUseFrugs = new System.Windows.Forms.Button();
            this.bBuyDrugs = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccountingForTakingPills.Properties.Resources.medsister;
            this.pictureBox1.Location = new System.Drawing.Point(96, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 531);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добро пожаловать, ";
            // 
            // bListOfDrugs
            // 
            this.bListOfDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bListOfDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bListOfDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bListOfDrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bListOfDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bListOfDrugs.Location = new System.Drawing.Point(464, 246);
            this.bListOfDrugs.Name = "bListOfDrugs";
            this.bListOfDrugs.Size = new System.Drawing.Size(471, 54);
            this.bListOfDrugs.TabIndex = 6;
            this.bListOfDrugs.Text = "Работа с списком лекарств";
            this.bListOfDrugs.UseVisualStyleBackColor = false;
            this.bListOfDrugs.Click += new System.EventHandler(this.WorkWithListOfDrugs);
            // 
            // bUseFrugs
            // 
            this.bUseFrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bUseFrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUseFrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bUseFrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUseFrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUseFrugs.Location = new System.Drawing.Point(464, 350);
            this.bUseFrugs.Name = "bUseFrugs";
            this.bUseFrugs.Size = new System.Drawing.Size(471, 54);
            this.bUseFrugs.TabIndex = 7;
            this.bUseFrugs.Text = "Приём лекарств";
            this.bUseFrugs.UseVisualStyleBackColor = false;
            this.bUseFrugs.Click += new System.EventHandler(this.CheckUseOfDrugs);
            // 
            // bBuyDrugs
            // 
            this.bBuyDrugs.BackColor = System.Drawing.Color.SlateGray;
            this.bBuyDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBuyDrugs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bBuyDrugs.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuyDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBuyDrugs.Location = new System.Drawing.Point(464, 452);
            this.bBuyDrugs.Name = "bBuyDrugs";
            this.bBuyDrugs.Size = new System.Drawing.Size(471, 54);
            this.bBuyDrugs.TabIndex = 8;
            this.bBuyDrugs.Text = "Покупка лекарств";
            this.bBuyDrugs.UseVisualStyleBackColor = false;
            this.bBuyDrugs.Click += new System.EventHandler(this.BuyDrugs);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Crimson;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bExit.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(645, 25);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(279, 54);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(964, 593);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bBuyDrugs);
            this.Controls.Add(this.bUseFrugs);
            this.Controls.Add(this.bListOfDrugs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bListOfDrugs;
        private System.Windows.Forms.Button bUseFrugs;
        private System.Windows.Forms.Button bBuyDrugs;
        private System.Windows.Forms.Button bExit;
    }
}