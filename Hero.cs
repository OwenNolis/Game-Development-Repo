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
        private Texture2D heroTexture;
        private Animation animation;
        private Vector2 position;
        private Vector2 speed;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animation = new Animation();

            // CharacterSheet
            animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(180, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(360, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(540, 0, 180, 248)));
            animation.AddFrame(new AnimationFrame(new Rectangle(720, 0, 180, 248)));

            // MilitaryRobot
            //animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 75, 81)));
            //animation.AddFrame(new AnimationFrame(new Rectangle(80, 0, 75, 81)));
            //animation.AddFrame(new AnimationFrame(new Rectangle(160, 0, 75, 81)));
            //animation.AddFrame(new AnimationFrame(new Rectangle(240, 0, 75, 81)));

            position = new Vector2(10, 10);
            speed = new Vector2(1, 1);
        }

        public void Update(GameTime gameTime)
        {
            Move();
            animation.Update(gameTime);
        }

        private void Move()
        {
            position += speed;

            if(position.X > 630 || position.X < -40)
            {
                speed.X *= -1;
            }
            if(position.Y > 250 || position.Y < -40)
            {
                speed.Y *= -1;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // CharacterSheet
            spriteBatch.Draw(heroTexture, position, animation.CurrentFrame.SourceRectangle , Color.White);

            // MilitaryRobot
            //spriteBatch.Draw(heroTexture, new Vector2(10,10), animation.CurrentFrame.SourceRectangle, Color.White);
        }

    }
}
