//System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//OpenTK
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace RFtest_on_git
{
    public class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Hello, world!");

            //Get the primary display device
            DisplayDevice cur_display=DisplayDevice.GetDisplay(DisplayIndex.Primary);

            Console.WriteLine(cur_display);

            //Create a window
            GameWindow dispWindow = new GameWindow();
            dispWindow.Run();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    sealed class GameWindow : OpenTK.GameWindow {
        public GameWindow()
        :base(1280, 720, GraphicsMode.Default, "figuring out openGL",
        GameWindowFlags.Default, DisplayDevice.Default,
        3, 0, GraphicsContextFlags.ForwardCompatible) {
             
        }

        protected override void OnResize(EventArgs e) {
            GL.Viewport(0, 0, this.Width, this.Height);     //Sets what part of the window is rendering (i.e. all of it)

        }

        protected override void OnLoad(EventArgs e) {
            //placeholder
        }

        protected override void OnUpdateFrame(FrameEventArgs e) {
            //logic
        }

        protected override void OnRenderFrame(FrameEventArgs e) {
            GL.ClearColor(Color4.Green);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            this.SwapBuffers();
        }
    }

    struct Vertex { //Immutable struct that just stores vertex data
        private readonly Vector3 pos;      //Position
        private readonly Color4 col;       //Color
        public const int size = (3 + 4) * 4;
        public Vertex(Vector3 pos, Color4 col) {
            this.pos = pos; this.col = col;
        }
    }

    public class VertexArray {

    }
}
