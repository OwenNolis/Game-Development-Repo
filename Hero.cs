using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
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
        private Vector2 acceleration;
        private Vector2 mouseVector;

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
            acceleration = new Vector2(0.1f, 0.1f);
        }

        public void Update(GameTime gameTime)
        {
            Move(GetMouseState());
            animation.Update(gameTime);
        }

        private Vector2 GetMouseState()
        {
            MouseState state = Mouse.GetState();
            mouseVector = new Vector2(state.X, state.Y);
            return mouseVector;
        }

        private void Move(Vector2 mouse)
        {
            var direction = Vector2.Add(mouse, -position);
            direction.Normalize();
            direction = Vector2.Multiply(direction, 3f);    // Keeps hovering around mouse ==> Distoring direction; useful for enemies roaming around hero

            speed += direction;
            speed = Limit(speed,5);
            position += speed;

            if(position.X > 630 || position.X < -40)
            {
                speed.X *= -1;
                acceleration.X *= -1;
            }
            if(position.Y > 250 || position.Y < -40)
            {
                speed.Y *= -1;
                acceleration *= -1;
            }
        }

        private Vector2 Limit(Vector2 v, float max) 
        {
            if(v.Length() > max)
            {
                var ratio = max / v.Length();
                v.X = v.X * ratio;
                v.Y = v.Y * ratio;
            }
            return v;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // CharacterSheet
            spriteBatch.Draw(heroTexture, position, animation.CurrentFrame.SourceRectangle , Color.White);

            // MilitaryRobot
            //spriteBatch.Draw(heroTexture, position, animation.CurrentFrame.SourceRectangle, Color.White);
        }

    }
}
