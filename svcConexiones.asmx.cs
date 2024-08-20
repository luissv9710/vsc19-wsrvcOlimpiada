using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
// ------------------------------
using System.Data;
// ------------------------------

namespace wsrvcOlimpiada
{
    /// <summary>
    /// Descripción breve de svcConexiones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class svcConexiones : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet vw_Complejo() {
            clsConexiones objeto = new clsConexiones();
            return objeto.vw_Complejo();
        }
        [WebMethod]
        public DataSet vw_ComplejoFiltro(string filtro)
        {
            clsConexiones objeto = new clsConexiones();
            return objeto.vw_ComplejoFiltro(filtro);
        }
        [WebMethod]
        public DataSet vw_Sede()
        {
            clsConexiones objeto = new clsConexiones();
            return objeto.vw_Sede();
        }
        [WebMethod]
        public DataSet sp_ControlAcceso(string usuario, 
                                        string contrasena)
        {
            clsConexiones objeto = new clsConexiones();
            return objeto.sp_ControlAcceso(usuario, contrasena);
        }

        [WebMethod]
        public DataSet sp_InsComplejo(  string nombre,
                                        string localizacion,
                                        string jefe,
                                        string area,
                                        string sede
                                        )
        {
            clsConexiones objeto = new clsConexiones();
            return objeto.sp_InsComplejo(nombre,
                                         localizacion,
                                         jefe, area, sede);
        }

    }
}
