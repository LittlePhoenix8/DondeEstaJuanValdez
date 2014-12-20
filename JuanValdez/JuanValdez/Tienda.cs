using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuanValdez
{
    class Tienda
    {
        private string nombre;
        private string comuna;
        private string dirección;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        
        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }
        
    }
}
