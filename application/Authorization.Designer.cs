
namespace AccountingForTakingPills
{
    partial class Authorization
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
            this.bEnter = new System.Windows.Forms.Button();
            this.bRegistr = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.Color.SlateGray;
            this.bEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEnter.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEnter.Location = new System.Drawing.Point(227, 375);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(400, 54);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Вход";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.EnterInTheSystem);
            // 
            // bRegistr
            // 
            this.bRegistr.BackColor = System.Drawing.Color.SlateGray;
            this.bRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRegistr.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRegistr.Location = new System.Drawing.Point(227, 452);
            this.bRegistr.Name = "bRegistr";
            this.bRegistr.Size = new System.Drawing.Size(400, 54);
            this.bRegistr.TabIndex = 1;
            this.bRegistr.Text = "Регистрация";
            this.bRegistr.UseVisualStyleBackColor = false;
            this.bRegistr.Click += new System.EventHandler(this.RegistrationInTheSystem);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbLogin.Location = new System.Drawing.Point(227, 145);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(400, 54);
            this.tbLogin.TabIndex = 2;

            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.BackColor = System.Drawing.Color.DarkGreen;
            this.lLogin.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lLogin.Location = new System.Drawing.Point(66, 145);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(147, 54);
            this.lLogin.TabIndex = 3;
            this.lLogin.Text = "Логин";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.BackColor = System.Drawing.Color.DarkGreen;
            this.lPassword.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lPassword.Location = new System.Drawing.Point(42, 253);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(181, 54);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.PaleGreen;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbPassword.Location = new System.Drawing.Point(227, 253);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(400, 54);
            this.tbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(168, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вход в систему";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(685, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bRegistr);
            this.Controls.Add(this.bEnter);
            this.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bRegistr;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
    }
}