using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace comercio_clase1
{
    /// <summary>
    /// Descripción breve de servicioPrueba
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class servicioPrueba : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public List<Clientes> traerClientes()
        {
            List<Clientes> cli = new List<Clientes>();
            cli.Add(new Clientes() { id = 1, cuenta = 123, nombre = "Jose" });
            cli.Add(new Clientes() { id = 2, cuenta = 1234, nombre = "Maria" });
            cli.Add(new Clientes() { id = 3, cuenta = 12345, nombre = "Jesus" });
            return cli;
        }

        [WebMethod]
        public Clientes traerCliente(int id)
        {
            List<Clientes> cli = new List<Clientes>();
            cli.Add(new Clientes() { id = 1, cuenta = 123, nombre = "Jose" });
            cli.Add(new Clientes() { id = 2, cuenta = 1234, nombre = "Maria" });
            cli.Add(new Clientes() { id = 3, cuenta = 12345, nombre = "Jesus" });
            return cli.SingleOrDefault(x=> x.id==id);
        }




    }
}
