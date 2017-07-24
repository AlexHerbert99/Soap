using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clientesConsumer.localhost;

namespace clientesConsumer
{
    class Program
    {
        static servicioPrueba ws = new servicioPrueba();
        static void Main(string[] args)
        {
            var x = ws.traerClientes();

            Clientes[] cli;
            cli = ws.traerClientes();
            foreach (Clientes z in cli)
            {
                Console.WriteLine(z.id);
                Console.WriteLine(z.cuenta);
                Console.WriteLine(z.nombre);
            }

            Console.WriteLine(ws.HelloWorld());
            Console.WriteLine(ws.traerCliente(2).cuenta);
            Console.ReadLine();
        }
    }
}
