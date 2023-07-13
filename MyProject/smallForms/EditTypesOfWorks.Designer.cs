namespace MyProject.smallForms
{
    partial class EditTypesOfWorks
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditPrice = new System.Windows.Forms.TextBox();
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPrice = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.DataGridView();
            this.SearchService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EditPrice);
            this.groupBox2.Controls.Add(this.EditName);
            this.groupBox2.Controls.Add(this.EditButton);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 127);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Внесение изменений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Название:";
            // 
            // EditPrice
            // 
            this.EditPrice.Location = new System.Drawing.Point(87, 58);
            this.EditPrice.Name = "EditPrice";
            this.EditPrice.Size = new System.Drawing.Size(163, 20);
            this.EditPrice.TabIndex = 24;
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(87, 27);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(163, 20);
            this.EditName.TabIndex = 23;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(112, 90);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 31);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Внести изменения";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddPrice);
            this.groupBox1.Controls.Add(this.AddName);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(336, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 133);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление новой услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название:";
            // 
            // AddPrice
            // 
            this.AddPrice.Location = new System.Drawing.Point(87, 64);
            this.AddPrice.Name = "AddPrice";
            this.AddPrice.Size = new System.Drawing.Size(163, 20);
            this.AddPrice.TabIndex = 19;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(87, 29);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(163, 20);
            this.AddName.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(112, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 31);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Services
            // 
            this.Services.AllowUserToAddRows = false;
            this.Services.AllowUserToDeleteRows = false;
            this.Services.AllowUserToResizeColumns = false;
            this.Services.AllowUserToResizeRows = false;
            this.Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Services.Location = new System.Drawing.Point(19, 51);
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            this.Services.RowHeadersWidth = 51;
            this.Services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Services.Size = new System.Drawing.Size(308, 237);
            this.Services.TabIndex = 22;
            this.Services.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Makes_CellClick);
            // 
            // SearchService
            // 
            this.SearchService.Location = new System.Drawing.Point(78, 14);
            this.SearchService.Name = "SearchService";
            this.SearchService.Size = new System.Drawing.Size(203, 20);
            this.SearchService.TabIndex = 21;
            this.SearchService.TextChanged += new System.EventHandler(this.SearchMake_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Поиск:";
            // 
            // EditTypesOfWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.SearchService);
            this.Controls.Add(this.label1);
            this.Name = "EditTypesOfWorks";
            this.Text = "EditListOfTasks";
            this.Load += new System.EventHandler(this.EditService_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView Services;
        private System.Windows.Forms.TextBox SearchService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EditPrice;
        private System.Windows.Forms.TextBox EditName;
    }
}