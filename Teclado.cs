using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Proyecto
{
    class Teclado
    {
        float angulo, x, y, z;
        bool rotar, trasladar, escalar;
        public Teclado()
        {
            angulo=0.0f;
            x = y = z = 0.0f;
            rotar = trasladar = escalar = false;
        }
        public Teclado(Escenario esc)
        {

        }
       
        public void transformaciones(Escenario escenario)
        {
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.R))//Rotacion
            {
                this.angulo = 0.0f;
                this.x = this.y = this.z = 0.0f;
                this.rotar = true;
                this.trasladar = this.escalar = false;
            }
            if (input.IsKeyDown(Key.T))//traslacion
            {
                this.x = this.y = this.z = 0.0f;
                this.trasladar = true;
                this.rotar = this.escalar = false;
            }
            if (input.IsKeyDown(Key.E))//Escalacion
            {
                this.x = this.y = this.z = 0.0f;
                this.escalar = true;
                this.trasladar = this.rotar = false;
            }

            if (input.IsKeyDown(Key.Right))//eje X
            {
                if (this.rotar) escenario.Rotar(angulo, 0, 1, 0);
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) { escenario.Escalar(x, y, z); }
                x += .3f;
                angulo += 0.5f;
            }

            if (input.IsKeyDown(Key.Left))//eje -X
            {
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) { escenario.Escalar(x, y, z); }
                x -= 0.3f;
            }

            if (input.IsKeyDown(Key.Up))//eje Y
            {
                if (this.rotar) escenario.Rotar(angulo, 1, 0, 0);
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) escenario.Escalar(x, y, z);

                angulo += 0.5f;
                y += 0.3f;
            }
            if (input.IsKeyDown(Key.Down))//eje -Y
            {
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) escenario.Escalar(x, y, z);

                y -= 0.1f;
            }


            if (input.IsKeyDown(Key.Down))//eje Z
            {
                if (this.rotar) escenario.Rotar(angulo, 1, 0, 1);
                angulo += 0.5f;
            }


            if (input.IsKeyDown(Key.S))//eje Z
            {
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) escenario.Escalar(x, y, z);
                z += 0.3f;
            }

            if (input.IsKeyDown(Key.Z))//eje -Z
            {
                if (this.trasladar) escenario.Trasladar(x, y, z);
                if (this.escalar) escenario.Escalar(x, y, z);
                z -= 0.3f;
            }

        }
    }
}
