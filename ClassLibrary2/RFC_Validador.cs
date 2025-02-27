using System;
using System.Text.RegularExpressions;

namespace BibliotecaControles
{
    public static class RFCValidator
    {
        private static readonly Regex rfcRegex = new Regex(@"^[A-ZÑ&]{4}\d{6}[A-Z\d]{2,3}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public static bool EsRFCValido(string rfc)
        {
            return rfcRegex.IsMatch(rfc.ToUpper());
        }
    }
}
