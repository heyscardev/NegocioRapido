using NegocioRapido.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.ViewModel
{
    public class Datos
    {
        private static BaseDatos _instance = new BaseDatos();
        private Datos()
        {
        }
        public static BaseDatos getBaseDatos()
        {
            return _instance;
        }
    }
}
