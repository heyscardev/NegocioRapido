using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NegocioRapido.View.Herramientas
{
    public class Validaciones
    {
        public static void SoloLetrasTabEnter(KeyEventArgs e)
        {
            e.Handled = false;
            if (!(e.Key >= Key.A && e.Key <= Key.Z) && e.Key != Key.Tab && e.Key != Key.Enter && e.Key != Key.Back)
            {
                e.Handled = true;
                Console.Beep();
            }
        }
        public static void SoloNumeroTabEnter(KeyEventArgs e)
        {
            e.Handled = false;
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9
                || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                && e.Key != Key.Tab 
                && e.Key != Key.Enter
                && e.Key != Key.Back
                )
            {
                e.Handled = true;
                Console.Beep();
            }
        }
        public static bool IsCorreo(string correo)
        {
            if (correo.Contains("@")) return true;
            return false;
        }

    }
}
