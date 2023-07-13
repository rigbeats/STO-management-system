namespace MyProject.smallForms
{
    partial class EditModels
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
            this.EditString = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddString = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Models = new System.Windows.Forms.DataGridView();
            this.SearchModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfMakes = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Models)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditString);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Location = new System.Drawing.Point(336, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 119);
            this.groupBox2.TabIndex = 19;
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
            this.groupBox1.Controls.Add(this.listOfMakes);
            this.groupBox1.Controls.Add(this.AddString);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(336, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 149);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление новой модели";
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
            this.AddButton.Location = new System.Drawing.Point(87, 90);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 53);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Models
            // 
            this.Models.AllowUserToAddRows = false;
            this.Models.AllowUserToDeleteRows = false;
            this.Models.AllowUserToResizeColumns = false;
            this.Models.AllowUserToResizeRows = false;
            this.Models.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Models.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Models.Location = new System.Drawing.Point(19, 51);
            this.Models.Name = "Models";
            this.Models.ReadOnly = true;
            this.Models.RowHeadersWidth = 51;
            this.Models.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Models.Size = new System.Drawing.Size(308, 237);
            this.Models.TabIndex = 17;
            this.Models.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Models_CellClick);
            // 
            // SearchModel
            // 
            this.SearchModel.Location = new System.Drawing.Point(78, 14);
            this.SearchModel.Name = "SearchModel";
            this.SearchModel.Size = new System.Drawing.Size(203, 20);
            this.SearchModel.TabIndex = 16;
            this.SearchModel.TextChanged += new System.EventHandler(this.SearchModel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск:";
            // 
            // listOfMakes
            // 
            this.listOfMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listOfMakes.FormattingEnabled = true;
            this.listOfMakes.Location = new System.Drawing.Point(66, 63);
            this.listOfMakes.Name = "listOfMakes";
            this.listOfMakes.Size = new System.Drawing.Size(164, 21);
            this.listOfMakes.TabIndex = 18;
            // 
            // EditModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Models);
            this.Controls.Add(this.SearchModel);
            this.Controls.Add(this.label1);
            this.Name = "EditModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditModels";
            this.Load += new System.EventHandler(this.EditModels_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Models)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EditString;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddString;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView Models;
        private System.Windows.Forms.TextBox SearchModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listOfMakes;
    }
}