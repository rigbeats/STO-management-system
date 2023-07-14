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
            this.gvListOfServices = new System.Windows.Forms.DataGridView();
            this.serviceList = new System.Windows.Forms.Label();
            this.orderedService = new System.Windows.Forms.Label();
            this.buttonRemoveService = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.gvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.totalSum = new System.Windows.Forms.Label();
            this.finishOrder = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvListOfServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentOrder)).BeginInit();
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
            // gvListOfServices
            // 
            this.gvListOfServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListOfServices.Location = new System.Drawing.Point(12, 111);
            this.gvListOfServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvListOfServices.Name = "gvListOfServices";
            this.gvListOfServices.RowHeadersWidth = 51;
            this.gvListOfServices.RowTemplate.Height = 24;
            this.gvListOfServices.Size = new System.Drawing.Size(473, 315);
            this.gvListOfServices.TabIndex = 2;
            this.gvListOfServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListOfServices_CellContentClick);
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
            // buttonRemoveService
            // 
            this.buttonRemoveService.Location = new System.Drawing.Point(491, 185);
            this.buttonRemoveService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveService.Name = "buttonRemoveService";
            this.buttonRemoveService.Size = new System.Drawing.Size(75, 66);
            this.buttonRemoveService.TabIndex = 5;
            this.buttonRemoveService.Text = "<----";
            this.buttonRemoveService.UseVisualStyleBackColor = true;
            this.buttonRemoveService.Click += new System.EventHandler(this.buttonRemoveService_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(491, 297);
            this.buttonAddService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(75, 66);
            this.buttonAddService.TabIndex = 6;
            this.buttonAddService.Text = "---->";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // gvCurrentOrder
            // 
            this.gvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCurrentOrder.Location = new System.Drawing.Point(572, 111);
            this.gvCurrentOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvCurrentOrder.Name = "gvCurrentOrder";
            this.gvCurrentOrder.RowHeadersWidth = 51;
            this.gvCurrentOrder.RowTemplate.Height = 24;
            this.gvCurrentOrder.Size = new System.Drawing.Size(483, 315);
            this.gvCurrentOrder.TabIndex = 7;
            this.gvCurrentOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCurrentOrder_CellContentClick);
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
            this.finishOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finishOrder.Name = "finishOrder";
            this.finishOrder.Size = new System.Drawing.Size(75, 23);
            this.finishOrder.TabIndex = 10;
            this.finishOrder.Text = "Готово";
            this.finishOrder.UseVisualStyleBackColor = true;
            this.finishOrder.Click += new System.EventHandler(this.finishOrder_Click);
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
            this.Controls.Add(this.gvCurrentOrder);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.buttonRemoveService);
            this.Controls.Add(this.orderedService);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.gvListOfServices);
            this.Controls.Add(this.editClose);
            this.Controls.Add(this.editHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditOrder";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditOrder_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListOfServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editHelp;
        private System.Windows.Forms.Button editClose;
        private System.Windows.Forms.DataGridView gvListOfServices;
        private System.Windows.Forms.Label serviceList;
        private System.Windows.Forms.Label orderedService;
        private System.Windows.Forms.Button buttonRemoveService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.DataGridView gvCurrentOrder;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.Button finishOrder;
        private System.Windows.Forms.Label totalPrice;
    }
}