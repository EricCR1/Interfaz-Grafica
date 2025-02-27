using System;

public class Class1
{
	public Class1()
	{

        public Class1()
    {
        // Constructor de la clase CustomButton
    public CustomButton()
    {
        // Asignamos eventos para cuando el cursor entra y sale del botón
        this.MouseEnter += OnMouseEnter;
        this.MouseLeave += OnMouseLeave;
        // Asignamos un evento para manejar el doble clic
        this.DoubleClick += OnDoubleClick;
    }

    // Método que se ejecuta cuando el cursor entra en el botón
    private void OnMouseEnter(object sender, System.EventArgs e)
    {
        // Cambiamos el color de fondo del botón a azul claro
        this.BackColor = Color.LightBlue;
    }

    // Método que se ejecuta cuando el cursor sale del botón
    private void OnMouseLeave(object sender, System.EventArgs e)
    {
        // Restauramos el color de fondo del botón al color por defecto
        this.BackColor = SystemColors.Control;
    }

    // Método que se ejecuta cuando se hace doble clic en el botón
    private void OnDoubleClick(object sender, System.EventArgs e)
    {
        // Mostramos un mensaje de confirmación
        DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres continuar?", "Confirmación", MessageBoxButtons.YesNo);
        if (resultado == DialogResult.Yes)
        {
            // Aquí puedes agregar la lógica que se ejecutará si el usuario confirma
            MessageBox.Show("Acción confirmada.");
        }
        else
        {
            // Aquí puedes agregar la lógica que se ejecutará si el usuario cancela
            MessageBox.Show("Acción cancelada.");
        }
    }
}
