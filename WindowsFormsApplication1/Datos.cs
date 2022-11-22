using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Datos : Control
    {
        //Propiedades
        public byte[] Huella { get { return huella; } set { huella = value; } }
        //Variables
        byte[] huella;
        //Constructor
        public Datos()
        {
        }
    }
}
