using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TestSpriteMovement
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D texture;
        private Rectangle partRectangle;
        private int moveOn_X = 0;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            // CharacterSheet
            //partRectangle = new Rectangle(moveOn_X, 0,180, 248);

            // MilitaryRobot
            partRectangle = new Rectangle(moveOn_X, 0, 75, 81);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // CharacterSheet
            //texture = Content.Load<Texture2D>("CharacterSheet");

            // MilitaryRobot
            texture = Content.Load<Texture2D>("_textureMilitaryRobot_Movement");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.BurlyWood);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            // CharacterSheet
            //_spriteBatch.Draw(texture, new Vector2(10,10), partRectangle, Color.White);

            // MilitaryRobot
            _spriteBatch.Draw(texture, new Vector2(10,10), partRectangle, Color.White);

            _spriteBatch.End();

            // CharacterSheet
            /*
            moveOn_X += 180;
            if(moveOn_X > 900)
            {
                moveOn_X = 0;
            }
            partRectangle.X = moveOn_X;
            */

            // MilitaryRobot

            moveOn_X += 80;
            if (moveOn_X > 305)
            {
                moveOn_X = 0;
            }
            partRectangle.X = moveOn_X;

            base.Draw(gameTime);
        }
    }
}
