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
using System.Windows.Shapes;

namespace NegocioRapido.View
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            iniciarSesion();
        }

        private void enter_iniciar_sesion(object sender, KeyEventArgs e)
        {
             if(e.Key == Key.Enter)
            {
                iniciarSesion();
            }
        }
        private void iniciarSesion()
        {
            if (boxNombreUsuario.Text.Length == 0 || boxContraseña.Password.Length == 0)
                MessageBox.Show("Debe Rellenar Todos Los campos");
            else
            {
                Sesion s = Sesion.iniciarSesion(boxNombreUsuario.Text, boxContraseña.Password);
                if (s != null)
                {
                    //si inicio exitoso
                    MessageBox.Show("Usuario: " + s.Usuario.Nombre + " se ha logueado con exito");
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Invalido");
                }
            }
        }

    }
}
