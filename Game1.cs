using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace DoomedOfTheDeath
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D texture;
        private Rectangle partRectangle; // New code
        private int moveOn_X = 0; // New code

        Hero hero;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            partRectangle = new Rectangle(moveOn_X,0,141,81); // New code

            base.Initialize();

            hero = new Hero(texture);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            texture = Content.Load<Texture2D>("_textureMilitaryRobot_Movement");

            InitializeGameObjects();
        }

        private void InitializeGameObjects()
        {
            hero = new Hero(texture);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            hero.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here

            GraphicsDevice.Clear(Color.DarkGray);

            _spriteBatch.Begin();

            //_spriteBatch.Draw(texture, new Vector2(10,10),partRectangle, Color.White); // New code

            hero.Draw(_spriteBatch);

            

            // New code
          //  moveOn_X += 140;
          //  if (moveOn_X > 562)
          //      moveOn_X = 0;
         //  partRectangle.X = moveOn_X;
            // New code

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
