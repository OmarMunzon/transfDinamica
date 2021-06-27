using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using Proyecto.models;
namespace Proyecto
{
    class Escenario
    {
                
        Vector3 CMSilla,CMTable;        
        Hashtable Objetos;
        
        public Escenario()
        {            
            this.CMSilla = new Vector3(0,0,0);
            this.CMTable = new Vector3(0, -10, 0);
            
            
            this.Objetos=new Hashtable();
            loadObjetos();
        }

        void loadObjetos()        
        {
            Chair s=new Chair(CMSilla);
            Mesa m=new Mesa(CMTable);
            this.Objetos.Add("silla",s);
            //this.Objetos.Add("mesa", m);
        }
          
        public void DibujarEscenario()
        {                        
            foreach(IGraficarObject objeto in this.Objetos.Values){
                objeto.Dibujar();
            }
        }

        public void Rotar(float angulo, float X, float Y, float Z)
        {            
            foreach (IGraficarObject obj in Objetos.Values)
            {
                obj.Rotar(angulo,X,Y,Z);
            }
        }

        public void Trasladar(float X, float Y, float Z)
        {
            foreach (IGraficarObject obj in Objetos.Values)
            {
                obj.traslacion(X,Y,Z);
            }
        }

        public void Escalar(float X, float Y, float Z)
        {
            foreach (IGraficarObject obj in Objetos.Values)
            {
                obj.Escalacion(X,Y,Z);
            }            
        }






        //public void CargarObjetos(bool sw)
        //{
        //    int count = 0;
        //    foreach(IGraficarObject obj in Objetos.Values){
        //        if (!obj.getState())
        //        {
        //            obj.setState(sw);
        //            Console.WriteLine(obj);
        //            return;
        //        }
        //        else
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == Objetos.Count)
        //    {
        //        foreach (IGraficarObject obj in Objetos.Values)
        //        {
        //            obj.setState(false);
        //        }
        //    }                
        //}
         
    }//end class
}
