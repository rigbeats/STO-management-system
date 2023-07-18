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
            this.gvListOfServices = new System.Windows.Forms.DataGridView();
            this.serviceList = new System.Windows.Forms.Label();
            this.orderedService = new System.Windows.Forms.Label();
            this.buttonRemoveService = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.gvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.finishOrder = new System.Windows.Forms.Button();
            this.totalCost = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvListOfServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListOfServices
            // 
            this.gvListOfServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListOfServices.Location = new System.Drawing.Point(27, 47);
            this.gvListOfServices.Margin = new System.Windows.Forms.Padding(2);
            this.gvListOfServices.Name = "gvListOfServices";
            this.gvListOfServices.ReadOnly = true;
            this.gvListOfServices.RowHeadersWidth = 51;
            this.gvListOfServices.RowTemplate.Height = 24;
            this.gvListOfServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListOfServices.Size = new System.Drawing.Size(293, 208);
            this.gvListOfServices.TabIndex = 2;
            // 
            // serviceList
            // 
            this.serviceList.AutoSize = true;
            this.serviceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceList.Location = new System.Drawing.Point(24, 16);
            this.serviceList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(87, 18);
            this.serviceList.TabIndex = 3;
            this.serviceList.Text = "Все услуги:";
            // 
            // orderedService
            // 
            this.orderedService.AutoSize = true;
            this.orderedService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderedService.Location = new System.Drawing.Point(405, 16);
            this.orderedService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderedService.Name = "orderedService";
            this.orderedService.Size = new System.Drawing.Size(84, 18);
            this.orderedService.TabIndex = 4;
            this.orderedService.Text = "По заявке:";
            // 
            // buttonRemoveService
            // 
            this.buttonRemoveService.Location = new System.Drawing.Point(337, 63);
            this.buttonRemoveService.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveService.Name = "buttonRemoveService";
            this.buttonRemoveService.Size = new System.Drawing.Size(56, 54);
            this.buttonRemoveService.TabIndex = 5;
            this.buttonRemoveService.Text = "<----";
            this.buttonRemoveService.UseVisualStyleBackColor = true;
            this.buttonRemoveService.Click += new System.EventHandler(this.buttonRemoveService_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(337, 181);
            this.buttonAddService.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(56, 54);
            this.buttonAddService.TabIndex = 6;
            this.buttonAddService.Text = "---->";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // gvCurrentOrder
            // 
            this.gvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCurrentOrder.Location = new System.Drawing.Point(408, 47);
            this.gvCurrentOrder.Margin = new System.Windows.Forms.Padding(2);
            this.gvCurrentOrder.Name = "gvCurrentOrder";
            this.gvCurrentOrder.ReadOnly = true;
            this.gvCurrentOrder.RowHeadersWidth = 51;
            this.gvCurrentOrder.RowTemplate.Height = 24;
            this.gvCurrentOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCurrentOrder.Size = new System.Drawing.Size(293, 208);
            this.gvCurrentOrder.TabIndex = 7;
            // 
            // finishOrder
            // 
            this.finishOrder.Location = new System.Drawing.Point(607, 265);
            this.finishOrder.Margin = new System.Windows.Forms.Padding(2);
            this.finishOrder.Name = "finishOrder";
            this.finishOrder.Size = new System.Drawing.Size(94, 36);
            this.finishOrder.TabIndex = 10;
            this.finishOrder.Text = "Готово";
            this.finishOrder.UseVisualStyleBackColor = true;
            this.finishOrder.Click += new System.EventHandler(this.finishOrder_Click);
            // 
            // totalCost
            // 
            this.totalCost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalCost.Location = new System.Drawing.Point(468, 270);
            this.totalCost.Name = "totalCost";
            this.totalCost.ReadOnly = true;
            this.totalCost.Size = new System.Drawing.Size(120, 25);
            this.totalCost.TabIndex = 11;
            this.totalCost.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(408, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Итого:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 322);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finishOrder);
            this.Controls.Add(this.gvCurrentOrder);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.buttonRemoveService);
            this.Controls.Add(this.orderedService);
            this.Controls.Add(this.serviceList);
            this.Controls.Add(this.gvListOfServices);
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
        private System.Windows.Forms.DataGridView gvListOfServices;
        private System.Windows.Forms.Label serviceList;
        private System.Windows.Forms.Label orderedService;
        private System.Windows.Forms.Button buttonRemoveService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.DataGridView gvCurrentOrder;
        private System.Windows.Forms.Button finishOrder;
        private System.Windows.Forms.RichTextBox totalCost;
        private System.Windows.Forms.Label label3;
    }
}