namespace MyProject
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
            this.wrench = new System.Windows.Forms.PictureBox();
            this.authoriz = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.EnterData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wrench)).BeginInit();
            this.SuspendLayout();
            // 
            // wrench
            // 
            this.wrench.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.wrench.Image = global::MyProject.Properties.Resources.wrench;
            this.wrench.Location = new System.Drawing.Point(50, 53);
            this.wrench.Name = "wrench";
            this.wrench.Size = new System.Drawing.Size(150, 150);
            this.wrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wrench.TabIndex = 0;
            this.wrench.TabStop = false;
            // 
            // authoriz
            // 
            this.authoriz.Enabled = false;
            this.authoriz.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authoriz.ForeColor = System.Drawing.Color.Black;
            this.authoriz.Location = new System.Drawing.Point(240, 9);
            this.authoriz.Name = "authoriz";
            this.authoriz.Size = new System.Drawing.Size(198, 67);
            this.authoriz.TabIndex = 0;
            this.authoriz.Text = "Авторизация";
            this.authoriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(269, 79);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(138, 30);
            this.login.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(269, 134);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(138, 30);
            this.password.TabIndex = 2;
            // 
            // EnterData
            // 
            this.EnterData.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterData.Location = new System.Drawing.Point(257, 190);
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(165, 44);
            this.EnterData.TabIndex = 3;
            this.EnterData.Text = "Войти";
            this.EnterData.UseVisualStyleBackColor = true;
            this.EnterData.Click += new System.EventHandler(this.EnterData_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.EnterData);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.authoriz);
            this.Controls.Add(this.wrench);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wrench)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wrench;
        private System.Windows.Forms.Label authoriz;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button EnterData;
    }
}