namespace WindowsLab
{
    partial class FrmCaso2
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
            this.btnIngresoEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresoEdad
            // 
            this.btnIngresoEdad.Location = new System.Drawing.Point(313, 169);
            this.btnIngresoEdad.Name = "btnIngresoEdad";
            this.btnIngresoEdad.Size = new System.Drawing.Size(189, 75);
            this.btnIngresoEdad.TabIndex = 0;
            this.btnIngresoEdad.Text = "Ingresar Edad";
            this.btnIngresoEdad.UseVisualStyleBackColor = true;
            this.btnIngresoEdad.Click += new System.EventHandler(this.btnIngresoEdad_Click);
            // 
            // FrmCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresoEdad);
            this.Name = "FrmCaso2";
            this.Text = "FrmCaso2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoEdad;
    }
}