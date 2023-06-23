namespace MyProject
{
    partial class EditOrder
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
            this.editHelp = new System.Windows.Forms.Button();
            this.editClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceList = new System.Windows.Forms.Label();
            this.orderedService = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.totalSum = new System.Windows.Forms.Label();
            this.finishOrder = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // editHelp
            // 
            this.editHelp.Location = new System.Drawing.Point(12, 15);
            this.editHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editHelp.Name = "editHelp";
            this.editHelp.Size = new System.Drawing.Size(100, 28);
            this.editHelp.TabIndex = 0;
            this.editHelp.Text = "Справка";
            this.editHelp.UseVisualStyleBackColor = true;
            this.editHelp.Click += new System.EventHandler(this.editHelp_Click);
            // 
            // editClose
            // 
            this.editClose.Location = new System.Drawing.Point(120, 15);
            this.editClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editClose.Name = "editClose";
            this.editClose.Size = new System.Drawing.Size(100, 28);
            this.editClose.TabIndex = 1;
            this.editClose.Text = "Закрыть";
            this.editClose.UseVisualStyleBackColor = true;
            this.editClose.Click += new System.EventHandler(this.editClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(473, 315);
            this.dataGridView1.TabIndex = 2;
            // 
            // serviceList
            // 
            this.serviceList.AutoSize = true;
            this.serviceList.Location = new System.Drawing.Point(9, 65);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(82, 16);
            this.serviceList.TabIndex = 3;
            this.serviceList.Text = "Все услуги:";
            // 
            // orderedService
            // 
            this.orderedService.AutoSize = true;
            this.orderedService.Location = new System.Drawing.Point(569, 65);
            this.orderedService.Name = "orderedService";
            this.orderedService.Size = new System.Drawing.Size(77, 16);
            this.orderedService.TabIndex = 4;
            this.orderedService.Text = "По заявке:";
            this.orderedService.Click += new System.EventHandler(this.orderedService_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(572, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(483, 315);
            this.dataGridView2.TabIndex = 7;
            // 
            // totalSum
            // 
            this.totalSum.AutoSize = true;
            this.totalSum.Location = new System.Drawing.Point(569, 453);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(41, 16);
            this.totalSum.TabIndex = 8;
            this.totalSum.Text = "Итог:";
            // 
            // finishOrder
            // 
            this.finishOrder.Location = new System.Drawing.Point(831, 453);
            this.finishOrder.Name = "finishOrder";
            this.finishOrder.Size = new System.Drawing.Size(75, 23);
            this.finishOrder.TabIndex = 10;
            this.finishOrder.Text = "Готово";
            this.finishOrder.UseVisualStyleBackColor = true;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Location = new System.Drawing.Point(649, 453);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(44, 16);
            this.totalPrice.TabIndex = 11;
            this.totalPrice.Text = "label1";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.finishOrder);
            this.Controls.Add(this.totalSum);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderedService);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editClose);
            this.Controls.Add(this.editHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editHelp;
        private System.Windows.Forms.Button editClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label serviceList;
        private System.Windows.Forms.Label orderedService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.Button finishOrder;
        private System.Windows.Forms.Label totalPrice;
    }
}