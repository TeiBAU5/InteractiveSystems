using CSE3902_Sprint0.Controller;
using CSE3902_Sprint0.Sprites;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CSE3902_Sprint0
{
    public class Game1 : Game
    {
        //This stores the frame that the sprite is on so there aren't abrupt changes to it
        public static int currentPicture = 0;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private IController keyboardController;
        private IController mouseController;
        private ISprite text;
        private ISprite sprite;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = Constants.GAME_WIDTH;  // set this value to the desired width of your window
            _graphics.PreferredBackBufferHeight = Constants.GAME_HEIGHT;   // set this value to the desired height of your window
            _graphics.ApplyChanges();

            keyboardController = new KeyboardController();
            mouseController = new MouseController();

            //Default with the not moving not animated sprite
            sprite = new Sprite(Content);

            text = new TextSprite(Content);

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            ISprite sprite = null;

            //Keyboard gets precedence
            keyboardController.update(Keyboard.GetState(), Content);
            Constants.Actions nextAction = keyboardController.currentState();

            if(nextAction != Constants.Actions.Nothing) {
                if (nextAction == Constants.Actions.Quit) Exit();
                else sprite = keyboardController.getSprite(nextAction, Content);
            } 

            //If the keyboard didn't have anything to update, check the mouse
            else {
                mouseController.update(Mouse.GetState(), Content);
                nextAction = mouseController.currentState();
                if (nextAction == Constants.Actions.Quit) Exit();
                else sprite = keyboardController.getSprite(nextAction, Content);
            }

            if(nextAction != Constants.Actions.Nothing)
            {
                this.sprite = sprite;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            text.Draw(_spriteBatch);

            sprite.Draw(_spriteBatch);
            sprite.update();

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}