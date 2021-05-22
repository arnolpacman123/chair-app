using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace ChairApp
{
    public class Window
    {
        GameWindow window;

        private double left     = 0.0;
        private double right    = 50.0;
        private double bottom   = 0.0;
        private double top      = 50.0;
        private double zNear    = -1.0;
        private double zFar     = 1.0;

        public Window(GameWindow window)
        {
            this.window = window;

            this.Start();
        }

        public void Start()
        {
            window.Load += load;
            window.Resize += resize;
            window.RenderFrame += renderFrame;
            this.window.Run(1.0 / 60.0);
        }

        private void resize(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(left, right, bottom, top, zNear, zFar);
            GL.MatrixMode(MatrixMode.Modelview);
        }

        private void renderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Polygon);
            GL.Vertex2(20.0, 25.0);
            GL.Vertex2(25.0, 20.0);
            GL.Vertex2(30.0, 25.0);
            GL.Vertex2(25.0, 30.0);
            GL.Vertex2(25.0, 40.0);
            GL.Vertex2(20.0, 35.0);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(20.0, 25.0);
            GL.Vertex2(20.0, 20.0);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(25.0, 20.0);
            GL.Vertex2(25.0, 15.0);
            GL.End();
            GL.Begin(BeginMode.Lines);
            GL.Vertex2(30.0, 25.0);
            GL.Vertex2(30.0, 20.0);
            GL.End();
            window.SwapBuffers();
        }

        private void load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
