using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Windows.Resources;
using System.IO;
using System.Windows.Media;

namespace JuanValdez
{
    public partial class Local : PhoneApplicationPage
    {
        public Local()
        {
            InitializeComponent();
            this.Loaded += Local_Loaded;
        }
        void Local_Loaded(object sender, RoutedEventArgs e)
        {
            //SaveHTMLFile(xml.retornarHtml("Callao"));
            //navegador.Navigate(new Uri("TextFile1.htm", UriKind.Relative));
        }
        // Llega de la ventana anterior.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string newText = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("lugar", out newText))
            {
                //MessageBox.Show(newText);
                llenarVentana(newText);
            }
            base.OnNavigatedTo(e);
        }
        // Llena vista con datos.
        private void llenarVentana(string buscar)
        {
            xmlReader xml = new xmlReader(Application.GetResourceStream(new Uri("lugares.xml", System.UriKind.Relative)));

            List<Tienda> listaTienea = xml.retornarHtml(buscar);
            int contador = 1;

            foreach (Tienda tienda in listaTienea)
            {
                TextBlock txtNombreLocal = new TextBlock();
                txtNombreLocal.Text = tienda.Nombre;
                txtNombreLocal.FontSize = 36;
                txtNombreLocal.Foreground = new SolidColorBrush(Color.FromArgb(255, 243, 230, 184));
                txtNombreLocal.FontWeight = FontWeights.Bold;

                TextBlock txtDescripcionLocal = new TextBlock();
                txtDescripcionLocal.Text = tienda.Dirección;
                txtDescripcionLocal.Foreground = new SolidColorBrush(Color.FromArgb(255, 243, 230, 184));

                TextBlock txtComunaLocal = new TextBlock();
                txtComunaLocal.Text = tienda.Comuna;
                txtComunaLocal.Foreground = new SolidColorBrush(Color.FromArgb(255, 243, 230, 184));

                panelCentral.Children.Add(txtNombreLocal);
                panelCentral.Children.Add(txtDescripcionLocal);
                panelCentral.Children.Add(txtComunaLocal);

                contador++;
            }
        }
    }
}