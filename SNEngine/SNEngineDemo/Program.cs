using SFML.Graphics;
using SFML.Window;
using SNEngine;

namespace SNEngine.Demo
{
    public class Program
    {

        private static void Main(string[] args)
        {
            GameResources.Initialize();

            GameResources.LoadContent();

            GameWindow window = new GameWindow("SNEngine Demo");

            window.BeginRender();
            

        }

    }
}
