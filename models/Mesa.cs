using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

using Proyecto.models.PartesMesa;
namespace Proyecto
{
    class Mesa:IGraficarObject
    {                        
        List<IGraficarObject> LPartes;
        bool estado;

        //
        Hashtable partes;
        Vector3 cmtabla, cmpata,cmMesa;

        public Mesa(Vector3 CM)
        {
            this.estado = false;
            this.LPartes = new List<IGraficarObject>
            {
                new Tabla(CM), 
                new Pata(CM),                
            };
            this.cmMesa = CM;
            this.cmtabla = new Vector3(CM);
            this.cmpata  = new Vector3(CM);
            this.partes = new Hashtable();
            loadPartes();
        }

        void loadPartes()
        {
            Tabla t = new Tabla(cmMesa);
            Pata p = new Pata(cmMesa);
            this.partes.Add("tablaM",t);
            this.partes.Add("pataM", p);
        }

        public void Dibujar()
        {
            foreach (IGraficarObject p in partes.Values)
            {
                p.Dibujar();
            }   
        }

        public void Rotar(float angulo, float x, float y, float z) {
            foreach (IGraficarObject p in partes.Values)
            {
                p.Rotar(angulo, x, y, z);
            }
        }

        public void traslacion(float X, float Y, float Z)
        {
            foreach (IGraficarObject p in partes.Values)
            {
                p.traslacion(X,Y,Z);
            }
        }

        public void Escalacion(float X, float Y, float Z)
        {
            foreach (IGraficarObject p in partes.Values)
            {
                p.Escalacion(X, Y, Z);
            }
        }












        //public bool getState()
        //{
        //    return this.estado;
        //}

        //public void setState(bool sw)
        //{
        //    this.estado = sw;
            
        //}

        
    }//end class
}
