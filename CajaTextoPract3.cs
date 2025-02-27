using System;

public class Class1
{
	public Class1()
	{
		// Definimos un enumerador para los tipos de entrada permitidos
    public enum TipoEntrada { SoloNumeros, SoloLetras, Ambos }

    // Propiedad para definir el tipo de entrada permitido
    public TipoEntrada EntradaPermitida { get; set; } = TipoEntrada.Ambos;

    // Constructor de la clase CustomTextBox
    public CustomTextBox()
    {
        // Asignamos un evento para cuando el texto cambia
        this.TextChanged += OnTextChanged;
    }

    // Método que se ejecuta cuando el texto en el TextBox cambia
    private void OnTextChanged(object sender, System.EventArgs e)
    {
        // Validamos si la entrada permitida es solo números y el texto no cumple con el patrón
        if (EntradaPermitida == TipoEntrada.SoloNumeros && !System.Text.RegularExpressions.Regex.IsMatch(this.Text, @"^\d*$"))
        {
            // Cambiamos el color de fondo a rojo si no es válido
            this.BackColor = Color.Red;
        }
        // Validamos si la entrada permitida es solo letras y el texto no cumple con el patrón
        else if (EntradaPermitida == TipoEntrada.SoloLetras && !System.Text.RegularExpressions.Regex.IsMatch(this.Text, @"^[a-zA-Z]*$"))
        {
            // Cambiamos el color de fondo a rojo si no es válido
            this.BackColor = Color.Red;
        }
        else
        {
            // Restauramos el color de fondo al color por defecto si es válido
            this.BackColor = SystemColors.Window;
        }
    }

    // Método para validar si una cadena contiene solo números
    public bool EsSoloNumeros(string texto)
    {
        // Usamos una expresión regular para verificar si el texto contiene solo dígitos
        return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^\d*$");
    }

    // Método para validar si una cadena contiene solo letras
    public bool EsSoloLetras(string texto)
    {
        // Usamos una expresión regular para verificar si el texto contiene solo letras
        return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z]*$");
    }

    // Método para validar si un RFC es válido según el formato oficial en México
    public bool EsRFCValido(string rfc)
    {
        // Usamos una expresión regular para verificar el formato del RFC
        return System.Text.RegularExpressions.Regex.IsMatch(rfc, @"^[A-Z]{4}\d{6}[A-Z0-9]{2,3}$");
    }

    // Método para corregir errores comunes en la captura de RFCs
    public string CorregirRFC(string rfc)
    {
        // Convertimos el RFC a mayúsculas para corregir errores de formato
        return rfc.ToUpper();
    }
}
