using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Resources;
using System.Xml.Linq;
using Microsoft.Phone.Controls.Maps;
using System.Device.Location;
using System.Globalization;
using System.Windows;

namespace JuanValdez
{
    class xmlReader
    {
        XElement datos;
        StreamResourceInfo uriDatos;
        public xmlReader(StreamResourceInfo uriDatos)
        {
            this.uriDatos = uriDatos;
            datos = XElement.Load(uriDatos.Stream);
        }
        // Listar pins del mapa.
        public List<Pushpin> listarPushPin()
        {
            List<Pushpin> listaPin = new List<Pushpin>();
            var datosXml = from item
                       in datos.Elements("marker")
                           select item;

            foreach (XElement elemento in datosXml)
            {
                Pushpin ppin = new Pushpin();

                String lat = elemento.Attribute("lat").Value.ToString();
                String lng = elemento.Attribute("lng").Value.ToString();

                // Transforma . de latitud y longitud.
                lat = lat.Replace('.', Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
                lng = lng.Replace('.', Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));

                double latDouble = Convert.ToDouble(lat);
                double lngDouble = Convert.ToDouble(lng);

                ppin.Location = new GeoCoordinate(latDouble, lngDouble);
                ppin.Content = elemento.Attribute("label").Value.ToString();
                listaPin.Add(ppin);
            }
            return listaPin;
        }
        // Listar los nombres de los locales.
        public List<string> listaNombreLocales()
        {
            var datosXml = from item in datos.Elements("marker") select item;

            List<string> listaString = new List<string>();
            listaString.Add("Seleccione un local");

            foreach (XElement elemento in datosXml)
            {
                listaString.Add(elemento.Attribute("label").Value.ToString());
            }
            return listaString;
        }
        // Listar las comunas de los locales.
        public List<string> listaComunasLocales()
        {
            var datosXml = from item in datos.Elements("marker") select item;

            List<string> listaString = new List<string>();
            listaString.Add("Seleccione una comuna");

            foreach (XElement elemento in datosXml)
            {
                if (!listaString.Contains(elemento.Attribute("Barrio").Value.ToString()))
                {
                    listaString.Add(elemento.Attribute("Barrio").Value.ToString());

                }
            }
            return listaString;
        }
        // Retorla datos de las tiendas
        public List<Tienda> retornarHtml(string nombre)
        {
            string nombreLocal = "";
            string comunaLocal = "";
            string direcciónLocal = "";

            var datosXml = from item in datos.Elements("marker") select item;

            List<string> listaDatos = new List<string>();
            List<Tienda> listaTienda = new List<Tienda>();

            foreach (XElement elemento in datosXml)
            {
                if (elemento.Attribute("label").Value == nombre || elemento.Attribute("Barrio").Value == nombre)
                {
                    nombreLocal = elemento.Attribute("label").Value;
                    comunaLocal = elemento.Attribute("Barrio").Value;
                    direcciónLocal = elemento.Attribute("Desc").Value;

                    Tienda tienda = new Tienda();

                    tienda.Nombre = nombreLocal;
                    tienda.Comuna = comunaLocal;
                    tienda.Dirección = direcciónLocal;

                    listaTienda.Add(tienda);
                }
            }

            return listaTienda;
        }
    }
}
