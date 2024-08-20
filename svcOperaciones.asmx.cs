using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wsrvcOlimpiada
{
    /// <summary>
    /// Descripción breve de svcOperaciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class svcOperaciones : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string HelloWorldMsg(string mensaje)
        {
            return "Hola: " + mensaje;
        }

        [WebMethod]
        public string HelloWorldCls(string mensaje)
        {
            clsOperaciones objeto = 
                                new clsOperaciones();
            
            return objeto.HelloWorldCls(mensaje);
        }

        [WebMethod]
        public double calcHipotenusa(double ca, double co) {
            clsOperaciones objeto = new clsOperaciones();
            return objeto.calcHipotenusa(ca, co);
        }


    }
}
