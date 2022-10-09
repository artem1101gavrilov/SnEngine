using SFML.Graphics;
using SFML.System;

namespace SNEngine.Visual.GUI
{
    public class Text : IDisposable, IDrawableObject
    {
        private SFML.Graphics.Text _sfmlText = new SFML.Graphics.Text();

        public string DataText {get => _sfmlText.DisplayedString; set => _sfmlText.DisplayedString = value; }

        public uint Size {get => _sfmlText.CharacterSize; set => _sfmlText.CharacterSize = value;}

        public SFML.Graphics.Color Color {get => _sfmlText.FillColor; set => _sfmlText.FillColor = value; }

        public Vector2f Origin {get => _sfmlText.Origin; set => _sfmlText.Origin = value;}

        public Vector2f Position  {get => _sfmlText.Position; set => _sfmlText.Position = value;}

        public Font Font => _sfmlText.Font;

        public Text () 
        {
          FloatRect floatRect = _sfmlText.GetLocalBounds();

        Origin = new Vector2f(floatRect.Left + floatRect.Width / 2.0f, floatRect.Top + floatRect.Height / 2.0f);

        Color = SFML.Graphics.Color.White;

        DataText = "New Text";

        Size = 14;

        Debug.LogAction("new text as created. You should font to text");


        }

        public void SetFont (Font font) 
        {
             if (font == null) 
             {
                 throw new SNEngineNullReferenceException("font a text not must null");
             }

             _sfmlText.Font = font;
        }

        public void Dispose() => _sfmlText.Dispose();

        public FloatRect GetLocalBounds () 
        {
            return _sfmlText.GetLocalBounds();
        }

        public void Draw (RenderWindow renderWindow) =>  _sfmlText.Draw(renderWindow, RenderStates.Default);


    }
}