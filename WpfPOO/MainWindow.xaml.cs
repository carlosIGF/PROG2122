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

namespace WpfPOO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Label l = new Label();
            l.Content = "Email*";
            
            TextBox t = new TextBox();
            t.Text = "carlos.igformacion@gmail.com";
            t.Height = 20;
            t.Width = 50;

            
            principal.Children.Add(t);

            Button btn = new Button();
            btn.Content = "Abrir";
            btn.VerticalAlignment = VerticalAlignment.Top;

            l.Background = Brushes.Chocolate;

            Persona p = new Persona("Carlos", 27);
            principal.Children.Add(p.Mostrar());

            Persona p2 = new Persona("PEPE", 30);
            principal.Children.Add(p2.Mostrar());

        }
    }
}
