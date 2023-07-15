using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyFirstSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _texture;
        private Vector2 _position;

        private float xs, ys, _speed;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1532;
            _graphics.PreferredBackBufferHeight = 1305;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _texture = Content.Load<Texture2D>("bruh");
            _position = new Vector2(0, 0);
            xs = 0f; ys = 0f;
            _speed = 8f;
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                ys -= _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                ys += _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                xs -= _speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                xs += _speed;
            }

            _position.X += xs;
            _position.Y += ys;

            xs *= 0.8f;
            ys *= 0.8f;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}