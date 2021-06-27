using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
namespace Proyecto
{
    class Game : GameWindow
    {
     
        
        Escenario escenario;
        Teclado t;
        
        public Game(int w, int h) : base(w, h, GraphicsMode.Default) 
        {            
            this.escenario = new Escenario();
            this.t = new Teclado();
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                       
            t.transformaciones(escenario);
            escenario.DibujarEscenario();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
                
        protected override void OnResize(EventArgs e)
        {            
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 trans = Matrix4.CreateTranslation(0.0f, 0.0f, -70.0f);
            Matrix4 perspectiva =trans* Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Width / Height, 1.0f, 100.0f);//vista de la escena                                    
            GL.LoadMatrix(ref perspectiva);
            GL.MatrixMode(MatrixMode.Modelview);
            base.OnResize(e);
        }
    
        

    }
}
