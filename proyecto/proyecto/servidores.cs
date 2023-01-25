using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    public class servidores
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return nombre.ToString();
        }
    }

}
