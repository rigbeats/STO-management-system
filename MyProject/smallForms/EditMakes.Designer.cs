namespace MyProject.smallForms
{
    partial class EditMakes
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchMake = new System.Windows.Forms.TextBox();
            this.Makes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditString = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddString = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Makes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск:";
            // 
            // SearchMake
            // 
            this.SearchMake.Location = new System.Drawing.Point(86, 15);
            this.SearchMake.Name = "SearchMake";
            this.SearchMake.Size = new System.Drawing.Size(203, 20);
            this.SearchMake.TabIndex = 2;
            this.SearchMake.TextChanged += new System.EventHandler(this.SearchMake_TextChanged);
            // 
            // Makes
            // 
            this.Makes.AllowUserToAddRows = false;
            this.Makes.AllowUserToDeleteRows = false;
            this.Makes.AllowUserToResizeColumns = false;
            this.Makes.AllowUserToResizeRows = false;
            this.Makes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Makes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Makes.Location = new System.Drawing.Point(27, 52);
            this.Makes.Name = "Makes";
            this.Makes.ReadOnly = true;
            this.Makes.RowHeadersWidth = 51;
            this.Makes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Makes.Size = new System.Drawing.Size(308, 237);
            this.Makes.TabIndex = 7;
            this.Makes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Makes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditString);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Location = new System.Drawing.Point(344, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Внесение изменений";
            // 
            // EditString
            // 
            this.EditString.Location = new System.Drawing.Point(63, 28);
            this.EditString.Name = "EditString";
            this.EditString.Size = new System.Drawing.Size(163, 20);
            this.EditString.TabIndex = 7;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(87, 55);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 53);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Внести изменения";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddString);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(344, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 119);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление новой марки";
            // 
            // AddString
            // 
            this.AddString.Location = new System.Drawing.Point(66, 29);
            this.AddString.Name = "AddString";
            this.AddString.Size = new System.Drawing.Size(163, 20);
            this.AddString.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(87, 55);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 53);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditMakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Makes);
            this.Controls.Add(this.SearchMake);
            this.Controls.Add(this.label1);
            this.Name = "EditMakes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMakes";
            this.Load += new System.EventHandler(this.EditMakes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Makes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchMake;
        private System.Windows.Forms.DataGridView Makes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EditString;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddString;
        private System.Windows.Forms.Button AddButton;
    }
}