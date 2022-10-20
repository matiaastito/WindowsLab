namespace WindowsLab
{
    partial class FrmCaso1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAreaRect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAreaRect
            // 
            this.btnAreaRect.Location = new System.Drawing.Point(257, 169);
            this.btnAreaRect.Name = "btnAreaRect";
            this.btnAreaRect.Size = new System.Drawing.Size(205, 50);
            this.btnAreaRect.TabIndex = 0;
            this.btnAreaRect.Text = "Calcular Area Rectangulo";
            this.btnAreaRect.UseVisualStyleBackColor = true;
            this.btnAreaRect.Click += new System.EventHandler(this.btnAreaRect_Click);
            // 
            // FrmCaso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAreaRect);
            this.Name = "FrmCaso1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAreaRect;
    }
}

