using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Proyecto.models.PartesChair
{
    class Tabla:IGraficarObject
    {

        float x, y, z;
        Vector3 cm,color;
        bool state;
                
        public Tabla(Vector3 CM)
        {
            this.state=false;
            this.x = this.y = this.z = 4.0f;
            this.cm = CM;
            this.color = new Vector3(0.0f,1.0f,0.0f);
        }

        public void Dibujar()
        {
            GL.PushMatrix();
            tabla();
            GL.PopMatrix();
        }

   
        public void Rotar(float angulo, float X, float Y, float Z)
        {           
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
        //    return state;
        //}

        //public void setState(bool sw)
        //{
        //    this.state = sw;
        //}

        void tabla()
        {
            //front
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y, color.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z + z);
            GL.End();

            //back
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y, color.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z - z);
            GL.End();

            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y - 0.5f, color.Z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z - z);
            GL.End();

            //bottom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y - 0.5f, color.Z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.End();

            //right
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y, color.Z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X + x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X + x, cm.Y + y - 6, cm.Z - z);
            GL.End();

            //left
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(color.X, color.Y, color.Z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z + z);
            GL.Vertex3(cm.X - x, cm.Y - y, cm.Z - z);
            GL.Vertex3(cm.X - x, cm.Y + y - 6, cm.Z - z);
            GL.End();
        }     

    }//end class
}
