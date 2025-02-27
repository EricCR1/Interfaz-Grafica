using System;
using System.Windows.Forms;

namespace BibliotecaControles
{
    public class CustomTextBox : TextBox
    {
        private TextBox textBox1;

        public enum TipoEntrada { Numeros, Letras, Ambos }
        public TipoEntrada Tipo { get; set; } = TipoEntrada.Ambos;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (Tipo == TipoEntrada.Numeros && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (Tipo == TipoEntrada.Letras && !char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
