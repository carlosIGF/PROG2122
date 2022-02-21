using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfPOO
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Grid Mostrar()
        {
            Label l = new Label();
            l.Content = "Nombre: " + nombre;

            Label edad = new Label();
            edad.Content = "Edad: " + this.edad;
            edad.HorizontalAlignment = HorizontalAlignment.Right;

            Grid g = new Grid();
            g.Children.Add(l);
            g.Children.Add(edad);

            return g;
        }
    }
}
