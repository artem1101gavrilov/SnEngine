using SFML.Graphics;
using SFML.Window;

namespace SNEngine;
public class GameWindow
{

    public event Action OnClosed;

     private RenderWindow _window;

     public string Title {get; internal set;}

      public GameWindow (string title = "New SNEngine Novel")
    {
        VideoMode video = new VideoMode(1200, 600);

        Color color = Color.Green;

        _window = new RenderWindow(video, title);

        Title = title;

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

            _window.Clear(Color.Black);

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
