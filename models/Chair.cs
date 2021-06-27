using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using Proyecto.models.PartesChair;
namespace Proyecto.models
{
    class Chair:IGraficarObject
    {
       
        bool estado;

        Hashtable partes;//lista  de partes
        Vector3 cmtabla, cmpatas, cmespaldar,CMSilla;
        public Chair(Vector3 cm)
        {
            this.estado = false;
            
            this.CMSilla=cm;
            this.cmespaldar=new Vector3(cm);
            this.cmtabla = new Vector3(cm);
            this.cmpatas = new Vector3(cm);
            this.partes = new Hashtable();
            loadPartes();
        }

        void loadPartes() {
            Tabla t = new Tabla(CMSilla);
            Patas p = new Patas(CMSilla);
            Espaldar e = new Espaldar(CMSilla);
            this.partes.Add("tablaS", t);
            this.partes.Add("pataS", p);
            this.partes.Add("espaldarS", e);
        }
        
        
        
        public void Dibujar()
        {
            foreach(IGraficarObject parte in partes.Values){
                parte.Dibujar();
            }
        }

        public void Rotar(float angulo, float X, float Y, float Z)
        {
            foreach (IGraficarObject parte in partes.Values)
            {
                parte.Rotar(angulo,X,Y,Z);
            }
        }

        public void traslacion(float X, float Y, float Z)
        {
            foreach (IGraficarObject parte in partes.Values)
            {
                parte.traslacion(X,Y,Z);
            }
        }

        public void Escalacion(float X, float Y, float Z)
        {
            foreach (IGraficarObject parte in partes.Values)
            {
                parte.Escalacion(X,Y,Z);
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
    }
}
