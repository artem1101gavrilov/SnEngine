using SFML.Graphics;
using SFML.Window;

namespace SNEngine;
public class GameWindow
{

    public event Action OnClosed;

     private RenderWindow _window;
      public GameWindow (string title = "New SNEngine Novel")
    {
        VideoMode video = new VideoMode(600, 600);

        Color color = Color.Green;

        _window = new RenderWindow(video, title);

        StartWhile(color);
    }

    private void StartWhile(Color color)
    {
        _window.Closed += Close;

        while (_window.IsOpen)
        {
            _window.DispatchEvents();

            _window.Clear(color);

            _window.Display();
        }
    }

    private void Close(object? sender, EventArgs e)
    {
        OnClosed?.Invoke();


        _window.Close();

    }

    public void SetTitle(string placeholder) 
    {
       _window.SetTitle(placeholder);

       Console.WriteLine(string.Format("New title of window {0}", _window.ToString()));
    }
}
