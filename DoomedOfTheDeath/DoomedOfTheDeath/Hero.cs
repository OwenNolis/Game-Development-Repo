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
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 400, 96)));
            animation.AddFrame(new AnimationFrame(new Rectangle(160, 0, 400, 96)));
            animation.AddFrame(new AnimationFrame(new Rectangle(320, 0, 400, 96)));
            animation.AddFrame(new AnimationFrame(new Rectangle(480, 0, 400, 96)));
        }

        public void Update()
        {
            animation.Update();
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, new Vector2(20, 10), animation.CurrentFrame.SourceRectangle, Color.White);
        }
    }
}
