using SFML.Graphics;
using SFML.System;

namespace SNEngine.Visual
{
    public interface IDrawableObject
    {
        public void Draw (RenderWindow renderWindow);
    }
}