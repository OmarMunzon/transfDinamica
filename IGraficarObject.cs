using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    interface IGraficarObject
    {
        void Dibujar();

        void Rotar(float angulo,float X,float Y,float Z);

        void traslacion(float x, float y, float z);

        void Escalacion(float x, float y, float z);

    }
}
