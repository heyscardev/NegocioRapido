using NegocioRapido.Model;
using NegocioRapido.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NegocioRapido.View.cliente
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class PrincipalCliente : UserControl
    {
        public PrincipalCliente()
        {
            InitializeComponent();
            datos.Child = InputDataEntidad.getInstance();
            actualizar_datos();
        }
        private void actualizar_datos()
        {
            
          
            tabla.ItemsSource = Datos.getBaseDatos().Clientes.ToList();
            
        }
    }
}
