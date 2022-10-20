namespace WindowsLab
{
    partial class FrmCaso5
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(281, 159);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(168, 68);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "Nuevo Usuario";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // FrmCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewUser);
            this.Name = "FrmCaso5";
            this.Text = "FrmCaso5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
    }
}