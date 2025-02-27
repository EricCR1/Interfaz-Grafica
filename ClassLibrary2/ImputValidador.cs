using System;
using System.Linq;

namespace BibliotecaControles
{
    public static class InputValidator
    {
        public static bool EsSoloNumeros(string texto) => texto.All(char.IsDigit);

        public static bool EsSoloLetras(string texto) => texto.All(char.IsLetter);
    }
}
