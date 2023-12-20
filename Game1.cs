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
        private Texture2D texture_MilitaryRobot_DeathBeamAttack;
        private Texture2D texture_MilitaryRobot_DeathBeam_Spawn;
        private Texture2D texture_MilitaryRobot_DeathBeam;

        Hero hero;
        Hero militaryRobot_DeathBeamAttack;
        Hero militaryRobot_DeathBeam_Spawn;
        Hero militaryRobot_DeathBeam;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            hero = new Hero(texture);
            militaryRobot_DeathBeamAttack = new Hero(texture_MilitaryRobot_DeathBeamAttack);
            militaryRobot_DeathBeam_Spawn = new Hero(texture_MilitaryRobot_DeathBeam_Spawn);
            militaryRobot_DeathBeam = new Hero(texture_MilitaryRobot_DeathBeam);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            texture = Content.Load<Texture2D>("_textureMilitaryRobot_Movement");
            texture_MilitaryRobot_DeathBeamAttack = Content.Load<Texture2D>("_textureMilitaryRobot_DeathBeamAttack");
            texture_MilitaryRobot_DeathBeam_Spawn = Content.Load<Texture2D>("_textureMilitaryRobot_DeathBeam_Spawn");
            texture_MilitaryRobot_DeathBeam = Content.Load<Texture2D>("_textureMilitaryRobot_DeathBeam");


            InitializeGameObjects();
        }

        private void InitializeGameObjects()
        {
            hero = new Hero(texture);
            militaryRobot_DeathBeamAttack = new Hero(texture_MilitaryRobot_DeathBeamAttack);
            militaryRobot_DeathBeam_Spawn = new Hero(texture_MilitaryRobot_DeathBeam_Spawn);
            militaryRobot_DeathBeam = new Hero(texture_MilitaryRobot_DeathBeam);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            hero.Update(gameTime);
            militaryRobot_DeathBeamAttack.Update(gameTime);
            militaryRobot_DeathBeam_Spawn.Update(gameTime);
            militaryRobot_DeathBeam.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here

            GraphicsDevice.Clear(Color.DarkGray);

            _spriteBatch.Begin();

            hero.Draw(_spriteBatch);
            militaryRobot_DeathBeamAttack.Draw(_spriteBatch);
            militaryRobot_DeathBeam_Spawn.Draw(_spriteBatch);
            militaryRobot_DeathBeam.Draw(_spriteBatch);

            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
