using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaControles
{

    public class CustomButton : Button
    {
        private Button button1;

        public Color ColorOriginal { get; set; } = Color.Yellow;
        public Color ColorHover { get; set; } = Color.Green;

        public CustomButton()
        {
            this.BackColor = ColorOriginal;
            this.MouseEnter += (s, e) => this.BackColor = Color.Yellow;
            this.MouseLeave += (s, e) => this.BackColor = Color.Violet;
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mi boton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
