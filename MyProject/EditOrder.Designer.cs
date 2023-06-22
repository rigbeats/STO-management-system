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
            this.SuspendLayout();
            // 
            // editHelp
            // 
            this.editHelp.Location = new System.Drawing.Point(13, 13);
            this.editHelp.Name = "editHelp";
            this.editHelp.Size = new System.Drawing.Size(75, 23);
            this.editHelp.TabIndex = 0;
            this.editHelp.Text = "Справка";
            this.editHelp.UseVisualStyleBackColor = true;
            this.editHelp.Click += new System.EventHandler(this.editHelp_Click);
            // 
            // editClose
            // 
            this.editClose.Location = new System.Drawing.Point(95, 12);
            this.editClose.Name = "editClose";
            this.editClose.Size = new System.Drawing.Size(75, 23);
            this.editClose.TabIndex = 1;
            this.editClose.Text = "Закрыть";
            this.editClose.UseVisualStyleBackColor = true;
            this.editClose.Click += new System.EventHandler(this.editClose_Click);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editClose);
            this.Controls.Add(this.editHelp);
            this.Name = "EditOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editHelp;
        private System.Windows.Forms.Button editClose;
    }
}