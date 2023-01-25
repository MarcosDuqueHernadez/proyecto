using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto
{
    public class BasesDatos
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
