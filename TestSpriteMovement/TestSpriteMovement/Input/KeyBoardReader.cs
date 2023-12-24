using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpriteMovement.Interfaces;

namespace TestSpriteMovement.Input
{
    class KeyBoardReader : IInputReader
    {
        public Vector2 ReadInput()
        {
            var direction = Vector2.Zero;

            KeyboardState state = Keyboard.GetState();

            #region Diagonal directions
            // Diagonal directions
            // Left-Up
            if (state.IsKeyDown(Keys.Left) && state.IsKeyDown(Keys.Up))
            {
                direction = new Vector2(-1, -1);
            }
            // Right-Up
            else if(state.IsKeyDown(Keys.Right) && state.IsKeyDown(Keys.Up)) 
            {
                direction = new Vector2(1, -1);
            }
            // Left-Down
            else if(state.IsKeyDown(Keys.Left) && state.IsKeyDown(Keys.Down))
            {
                direction = new Vector2(-1, 1);
            }
            // Right-Down
            else if(state.IsKeyDown(Keys.Right) && state.IsKeyDown(Keys.Down))
            {
                direction = new Vector2(1, 1);
            }
            #endregion

            #region Horizontal directions
            // Horizontal directions
            // Left
            else if (state.IsKeyDown(Keys.Left))
            {
                direction = new Vector2(-1, 0);
            }
            // Right
            else if (state.IsKeyDown(Keys.Right))
            {
                direction = new Vector2(1, 0);
            }
            #endregion

            #region Vertical directions
            // Vertical directions
            // Up
            else if (state.IsKeyDown(Keys.Up))
            {
                direction = new Vector2(0, -1);
            }
            // Down
            else if (state.IsKeyDown(Keys.Down))
            {
                direction = new Vector2(0, 1);
            }
            #endregion

            return direction;
        }
    }
}
