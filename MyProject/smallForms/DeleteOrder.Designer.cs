namespace MyProject.smallForms
{
    partial class DeleteOrder
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
            this.label = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(23, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(316, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Вы уверены что хотите удалить заявку?";
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(70, 84);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(82, 27);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "Да";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(212, 84);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(82, 27);
            this.No.TabIndex = 2;
            this.No.Text = "Нет";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // DeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 153);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(374, 192);
            this.Name = "DeleteOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
    }
}