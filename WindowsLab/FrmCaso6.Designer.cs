namespace WindowsLab
{
    partial class FrmCaso6
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
            this.btnInsertDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertDatos
            // 
            this.btnInsertDatos.Location = new System.Drawing.Point(141, 154);
            this.btnInsertDatos.Name = "btnInsertDatos";
            this.btnInsertDatos.Size = new System.Drawing.Size(167, 63);
            this.btnInsertDatos.TabIndex = 0;
            this.btnInsertDatos.Text = "Insertar Datos";
            this.btnInsertDatos.UseVisualStyleBackColor = true;
            this.btnInsertDatos.Click += new System.EventHandler(this.btnInsertDatos_Click);
            // 
            // FrmCaso6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertDatos);
            this.Name = "FrmCaso6";
            this.Text = "FrmCaso6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertDatos;
    }
}