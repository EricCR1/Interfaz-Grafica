namespace Prueba
{
    partial class Form1
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
            this.customButton1 = new BibliotecaControles.CustomButton();
            this.customTextBox1 = new BibliotecaControles.CustomTextBox();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.LightGray;
            this.customButton1.ColorHover = System.Drawing.Color.DarkGray;
            this.customButton1.ColorOriginal = System.Drawing.Color.LightGray;
            this.customButton1.Location = new System.Drawing.Point(292, 110);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(173, 53);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "customButton1";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Location = new System.Drawing.Point(255, 215);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(255, 20);
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.Tipo = BibliotecaControles.CustomTextBox.TipoEntrada.Ambos;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaControles.CustomButton customButton1;
        private BibliotecaControles.CustomTextBox customTextBox1;
    }
}

