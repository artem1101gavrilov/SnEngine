
namespace SNEngine.Demo
{
    public class Program : ISNEnginePointStart
    {

        private static GameWindow _window = null;

        private static void Main(string[] args)
        {
            Thread thread = new Thread(Render);

            thread.Start();

           GameResources.OnInitialized += LoadContent;  

        }

        private static void LoadContent()
        {
            GameResources.OnInitialized -= LoadContent;

            GameResources.LoadContent();


        }

        private static void Render(object? data)
        {
            GameResources.Initialize();

         _window = new GameWindow("SNEngine Demo");
          
         _window.BeginRender();
        }

        
    }
}
