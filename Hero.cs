using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSpriteMovement.Animations;
using TestSpriteMovement.Interfaces;

namespace TestSpriteMovement
{
    public  class Hero : IGameObject
    {
        Texture2D heroTexture;
        Animation animation;

        // Animation verwijderen private Rectangle partRectangle;
        // Animation verwijderen sprivate int moveOn_X = 0;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animation = new Animation();

            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(180, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(360, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(540, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(720, 0, 180, 248)));

            // CharacterSheet
            // Animation verwijderen 
            //partRectangle = new Rectangle(moveOn_X, 0,180, 248);

            // MilitaryRobot
            // Animation verwijderen 
            // partRectangle = new Rectangle(moveOn_X, 0, 75, 81);
        }

        public void Update()
        {
            animation.Update();

            // CharacterSheet
            // Animation verwijderen 
            /*
            moveOn_X += 180;
            if(moveOn_X > 900)
            {
                moveOn_X = 0;
            }
            partRectangle.X = moveOn_X;
            */

            // MilitaryRobot
            // Animation verwijderen 
            /*
            moveOn_X += 80;
            if (moveOn_X > 305)
            {
                moveOn_X = 0;
            }
            partRectangle.X = moveOn_X;
            */

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // CharacterSheet
            spriteBatch.Draw(heroTexture, new Vector2(10,10), animation.CurrentFrame.SourceRectangle , Color.White);

            // MilitaryRobot
            // spriteBatch.Draw(heroTexture, new Vector2(10,10), partRectangle, Color.White);
        }

    }
}
