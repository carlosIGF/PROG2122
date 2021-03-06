using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Práctica3Solucion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Validation(object sender, TextCompositionEventArgs e)
        {
            // Expresión regular para solo permitir dígitos
            // pero dejaría introducir espacios en blanco
            Regex regex = new Regex("[^0-9]+");

            // Utilizamos los parámetros de la función para solo escribir
            // el texto si coincide con el patrón de la expresión regular
            e.Handled = regex.IsMatch(e.Text);
        }

        // Función asociada a todos los eventos TextChanged de los
        // Textbox (para comprobar el estado del formulario)
        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ComprobarFormulario();
        }

        // Función asociada al check de Cliente
        // Rellena el ComboBox con los datos oportunos.
        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            ComboBox c = new ComboBox();
            c.Name = "cbProvincia";

            if (principal.FindName("cbProvincia") != null)
            {
                c = (ComboBox)principal.FindName("cbProvincia");

                c.Items.Add("VALENCIA");
            }
            else
            {
                c.Height = 20;
                c.Width = 100;

                for (int i = 0; i < 5; i++)
                {
                    ComboBoxItem cbi = new ComboBoxItem();
                    cbi.Content = "VLC";
                    c.Items.Add(cbi);
                }

                principal.Children.Add(c);
            }
        }

        // Función asociada al check de Distribuidor
        // Rellena el ComboBox con los datos oportunos.
        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            ComboBox c = new ComboBox();
            c.Name = "cbProvincia";

            if (principal.FindName("cbProvincia") != null)
            {
                c = (ComboBox)principal.FindName("cbProvincia");

                c.Items.Add("ALICANTE");
            }
            else
            {
                c.Height = 20;
                c.Width = 100;

                for (int i = 0; i < 5; i++)
                {
                    ComboBoxItem cbi = new ComboBoxItem();
                    cbi.Content = "ALC";
                    c.Items.Add(cbi);
                }

                principal.Children.Add(c);
            }
        }

        // Función asociada al cambio en el ComboBox para
        // comporbar el estado del formulario
        private void cbProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComprobarFormulario();
        }

        // Función que comprueba como esta el formulario de completo
        // para saber si se debe activar o no el botón Enviar
        public void ComprobarFormulario()
        {
            if (txtNombre.Text != ""
                && txtApellido1.Text != ""
                && (rbCliente.IsChecked == true
                    || rbDistribuidor.IsChecked == true)
                && txtTelefono1.Text != ""
                && txtEmail.Text != ""
                && txtDireccion.Text != ""
                && txtPostal.Text != ""
                && txtPoblacion.Text != "")
                btnEnviar.IsEnabled = true;
            else
                btnEnviar.IsEnabled = false;
        }

        // Función asociada al evento Click del botón Cancelar
        // que cierra el programa
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        // Función asociada al evento Click del botón Enviar
        // que muestra en un MessageBox la sentencia SQL correspondiente
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (rbCliente.IsChecked == true)
                MessageBox.Show("INSERT INTO clientes (....) VALUES (...)");
            else
                MessageBox.Show("INSERT INTO distribuidores (...) VALUES (...)");
        }
    }
}
