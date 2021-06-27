using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Proyecto.models.PartesMesa
{
    class Pata : IGraficarObject
    {
        float x, y, z;
        bool state;
        Vector3 cm,colour;

        public Pata(Vector3 CM)
        {
            this.cm = CM;            
            this.x =  6.0f ;
            this.y =  this.z = 4.0f;
            this.colour = new Vector3(0.5f, 0.5f, 1.0f);
        }

        public void Dibujar()
        {
            GL.PushMatrix();
            soporte();
            GL.PopMatrix();
        }

        void soporte()
        {
            
            //p1
            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X,colour.Y,colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z);
            GL.End();

            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z - 2);
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X + 0.1f, colour.Y + 0.1f, colour.Z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z - 2);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z - 2);
            GL.End();

            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z - 2);
            GL.End();
            //bottom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.End();

            //p2
            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z);
            GL.End();

            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z - 2);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X + 0.1f, colour.Y + 0.1f, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z - 2);
            GL.End();

            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z + z - 2);
            GL.End();
            //bottom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z + z - 2);
            GL.End();

            //p3
            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z);
            GL.End();

            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z + 2);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X + 0.1f, colour.Y + 0.1f, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z + 2);
            GL.End();

            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - y, cm.Z - z + 2);
            GL.End();
            //bottom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X + x - 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.End();

            //p4
            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z);
            GL.End();

            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z + 2);
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X + 0.1f, colour.Y + 0.1f, colour.Z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.End();

            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.End();
            //bottom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z + 2);
            GL.Vertex3(cm.X - x + 2, cm.Y - 2.5 * y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y - 2.5 * y, cm.Z - z);
            GL.End();
        }

        public void Rotar(float angulo, float X, float Y, float Z) {
            
            float ang = MathHelper.DegreesToRadians(angulo);
            GL.Rotate(angulo, X, Y, Z);
            
        }

        public void traslacion(float X, float Y, float Z)
        {
            
            Matrix4 matTrasnf = Matrix4.CreateTranslation(cm.X, cm.Y, cm.Z);
            Vector4 PosTraslacion = new Vector4(X, Y, Z, 1);
            Vector4 aux = matTrasnf * PosTraslacion;
            this.cm.X = aux.X;
            this.cm.Y = aux.Y;
            this.cm.Z = aux.Z;
         
        }

        public void Escalacion(float X, float Y, float Z)
        {
            Vector3 escalar = new Vector3(X, Y, Z);
            this.x = escalar.X * 0.1f + x;
            this.y = escalar.Y * 0.1f + x;
            this.z = escalar.Z * 0.1f + x;
            
        }










        //public bool getState()
        //{
        //    return this.state;
        //}

        //public void setState(bool sw)
        //{
        //    this.state = sw;
        //}
    }
}
