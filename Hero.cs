using DoomedOfTheDeath.Animations;
using DoomedOfTheDeath.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomedOfTheDeath
{
    public class Hero : IGameObject
    {
        Texture2D heroTexture;
        Animation animation;

        public Hero(Texture2D _textureMilitaryRobot)
        {
            heroTexture = _textureMilitaryRobot;
            animation = new Animation();

            // New code
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 141, 81)));
            animation.AddFrame(new AnimationFrame(new Rectangle(141, 0, 141, 81)));
            animation.AddFrame(new AnimationFrame(new Rectangle(282, 0, 141, 81)));
            animation.AddFrame(new AnimationFrame(new Rectangle(423, 0, 141, 81)));
            animation.AddFrame(new AnimationFrame(new Rectangle(564, 0, 141, 81)));
            // New code

            // Animation for Movement
            //animation.GetFramesFromTextureProperties(_textureMilitaryRobot.Width, _textureMilitaryRobot.Height, 4, 1);

            // Animation for Shield
            //animation.GetFramesFromTextureProperties(_textureMilitaryRobot.Width, _textureMilitaryRobot.Height, 10, 1);
        }

        public void Update(GameTime gameTime)
        {
            animation.Update(gameTime);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, new Vector2(300, 150), animation.CurrentFrame.SourceRectangle, Color.White);
        }
    }
}
