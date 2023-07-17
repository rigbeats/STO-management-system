namespace MyProject.smallForms
{
    partial class EditAccounts
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditPassword = new System.Windows.Forms.TextBox();
            this.EditLogin = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPassword = new System.Windows.Forms.TextBox();
            this.AddLogin = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.accounts = new System.Windows.Forms.DataGridView();
            this.SearchAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EditPassword);
            this.groupBox2.Controls.Add(this.EditLogin);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 127);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Внесение изменений";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(14, 90);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 31);
            this.delete.TabIndex = 27;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Логин:";
            // 
            // EditPassword
            // 
            this.EditPassword.Location = new System.Drawing.Point(87, 58);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.Size = new System.Drawing.Size(163, 20);
            this.EditPassword.TabIndex = 24;
            // 
            // EditLogin
            // 
            this.EditLogin.Location = new System.Drawing.Point(87, 27);
            this.EditLogin.Name = "EditLogin";
            this.EditLogin.Size = new System.Drawing.Size(163, 20);
            this.EditLogin.TabIndex = 23;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(142, 90);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 31);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Внести изменения";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddPassword);
            this.groupBox1.Controls.Add(this.AddLogin);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(336, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 133);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление аккаунта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Логин:";
            // 
            // AddPassword
            // 
            this.AddPassword.Location = new System.Drawing.Point(87, 64);
            this.AddPassword.Name = "AddPassword";
            this.AddPassword.Size = new System.Drawing.Size(163, 20);
            this.AddPassword.TabIndex = 19;
            // 
            // AddLogin
            // 
            this.AddLogin.Location = new System.Drawing.Point(87, 29);
            this.AddLogin.Name = "AddLogin";
            this.AddLogin.Size = new System.Drawing.Size(163, 20);
            this.AddLogin.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(112, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 31);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Enter += new System.EventHandler(this.AddButton_Click);
            // 
            // accounts
            // 
            this.accounts.AllowUserToAddRows = false;
            this.accounts.AllowUserToDeleteRows = false;
            this.accounts.AllowUserToResizeColumns = false;
            this.accounts.AllowUserToResizeRows = false;
            this.accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accounts.Location = new System.Drawing.Point(19, 52);
            this.accounts.Name = "accounts";
            this.accounts.ReadOnly = true;
            this.accounts.RowHeadersWidth = 51;
            this.accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accounts.Size = new System.Drawing.Size(308, 237);
            this.accounts.TabIndex = 27;
            this.accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accounts_CellClick);
            // 
            // SearchAccount
            // 
            this.SearchAccount.Location = new System.Drawing.Point(78, 14);
            this.SearchAccount.Name = "SearchAccount";
            this.SearchAccount.Size = new System.Drawing.Size(203, 20);
            this.SearchAccount.TabIndex = 26;
            this.SearchAccount.TextChanged += new System.EventHandler(this.SearchAccounts_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Поиск:";
            // 
            // EditAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accounts);
            this.Controls.Add(this.SearchAccount);
            this.Controls.Add(this.label1);
            this.Name = "EditAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditAccounts_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.TextBox EditLogin;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddPassword;
        private System.Windows.Forms.TextBox AddLogin;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView accounts;
        private System.Windows.Forms.TextBox SearchAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
    }
}