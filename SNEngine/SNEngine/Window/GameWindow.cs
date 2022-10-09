using SFML.Graphics;
using SFML.System;
using SFML.Window;



namespace SNEngine;
public class GameWindow
{

    public event Action OnClosed;
    
     

    private SNEngine.Visual.GUI.Text _textLoad = new Visual.GUI.Text();

     private RenderWindow _window;


    public string Title {get; internal set;}

    private Color BackgroundColor {get; set;} = new Color(97, 97, 97);


      public GameWindow (string title = "New SNEngine Novel")
    {
        VideoMode video = new VideoMode(800, 600);


        _window = new RenderWindow(video, title);

       _window.SetFramerateLimit(60);

       Font arialFont = new Font(GameResources.GetFulPathToFolber("arial.ttf"));

        Title = title;

        _textLoad.SetFont(arialFont);

        _textLoad.DataText = "load content... Please wait";

        _textLoad.Color = Color.White;

        _textLoad.Size = 24;

        FloatRect floatRect = _textLoad.GetLocalBounds();

        _textLoad.Origin = new Vector2f(floatRect.Left + floatRect.Width/2.0f, floatRect.Top + floatRect.Height/2.0f);

        _textLoad.Position = _window.GetView().Center;

        _window.Closed += Close;


    }

    public void BeginRender()
    {


        Render();
    }

    private void Render()
    {
        while (_window.IsOpen)
        {
            
            _window.DispatchEvents();

            _window.Clear(BackgroundColor);

            

            if (!GameResources.IsLoadContent) 
            {
                // test variant
                  
                 _textLoad.Draw(_window);
            }
       _window.Display();
        }


    }

    private void Close(object? sender, EventArgs e)
    {
        OnClosed?.Invoke();

        Debug.Log($"event of OnClosed called for {OnClosed?.GetInvocationList().Length} subcribes");

        Debug.Log("app has closed. SNEEngine threads as stopped.");

        _window.Close();

    }

    public void SetTitle(string placeholder) 
    {
       _window.SetTitle(placeholder);

        Title = placeholder;

       Debug.Log(string.Format("New title of window {0}", Title));
    }
}
