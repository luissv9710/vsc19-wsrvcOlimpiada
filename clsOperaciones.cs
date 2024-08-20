using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wsrvcOlimpiada
{
    public class clsOperaciones
    {
        public string HelloWorldCls(string mensaje)
        {
            return "Hola desde la clase: " + mensaje;
        }

        public double calcHipotenusa(double ca, double co) {
            double h;
            h = Math.Pow(Math.Pow(ca, 2) + Math.Pow(co, 2), 0.5);
            return h;
        }


    }
}