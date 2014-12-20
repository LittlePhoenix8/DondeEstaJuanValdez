using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace JuanValdez
{
    public partial class Buscar : PhoneApplicationPage
    {
        public Buscar()
        {
            InitializeComponent();
            this.Loaded += Buscar_Loaded;
        }

        void Buscar_Loaded(object sender, RoutedEventArgs e)
        {
            xmlReader xml = new xmlReader(Application.GetResourceStream(new Uri("lugares.xml", System.UriKind.Relative)));

            List<string> comunas = xml.listaComunasLocales();

            listaLugarVista.ItemsSource = comunas;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listaLugarVista.SelectedIndex != 0)
            {
                NavigationService.Navigate(new Uri("/Local.xaml?lugar=" + listaLugarVista.SelectedItem.ToString(), UriKind.Relative));
            }
        }
    }
}