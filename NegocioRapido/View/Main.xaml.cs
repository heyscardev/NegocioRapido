using NegocioRapido.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NegocioRapido.View.cliente;
using NegocioRapido.Model;

namespace NegocioRapido.View
{
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            
            

            

        }
        private void set_lateral_bars(TipoUsuario e)
        {
            switch (e)
            {
                case TipoUsuario.Administrador:

                    break;
            }
        }
        private Button  lateralBarButon(string url , string texto)
        {
           
            Button b = new Button();
            Grid butongrid = new Grid();
            b.Content = texto;
           
            b.Background = Brushes.Transparent;
            return b;
        }
        private void btn_cerrar_ventana_Click(object sender, RoutedEventArgs e)
        {
            
            Window este = new Window();
            este.Content = InputDataEntidad.getInstance(new Cliente());
            este.WindowStyle = WindowStyle.None;
            este.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            este.ShowInTaskbar = false;
            este.Topmost = true;
            este.Width = 400;
            este.Height = 600;
            este.ShowDialog();
            
           
            
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            //tooltip visibilidad
            ToolTip? tt = (e.Source as ListViewItem).ToolTip as ToolTip;
            if (tt != null)
                if (togle.IsChecked == true )
                    tt.Visibility = Visibility.Collapsed;
                else 
                    tt.Visibility=Visibility.Visible;
        }

        private void togle_Checked(object sender, RoutedEventArgs e)
        {
            contenedor_ventana.Opacity = 0.3;
         
        }

        private void togle_Unchecked(object sender, RoutedEventArgs e)
        {
            contenedor_ventana.Opacity = 1;
        }
    }
}
