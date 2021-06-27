using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Window ventana = new Window(700, 500, "Programacion  Grafica"))
            //{
            //    ventana.Run(1 / 60);
            //};
            using (Game ventana = new Game(700, 500))
            {
                ventana.Run(1 / 60);
            };
        }
    }
}
