using CSE3902_Sprint0.Sprites;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0.Controller
{
    public class MouseController : IController
    {
        MouseState mouseState;
        Dictionary<Constants.MousePositions, Constants.Actions> dictionary;

        public MouseController()
        {
            createDictionary();
        }

        private void createDictionary()
        {
            dictionary = new Dictionary<Constants.MousePositions, Constants.Actions>
            {
                { Constants.MousePositions.RightClick, Constants.Actions.Quit },
                { Constants.MousePositions.TopLeft,  Constants.Actions.Display_OneFrame_Fixed},
                { Constants.MousePositions.TopRight, Constants.Actions.Display_Animated_Fixed},
                { Constants.MousePositions.BottomLeft, Constants.Actions.Display_OneFrame_Moves },
                { Constants.MousePositions.BottomRight, Constants.Actions.Display_Animated_Moves },
                { Constants.MousePositions.None, Constants.Actions.Nothing },  
            };
        }

        private Constants.MousePositions generateMousePosition()
        {
            Constants.MousePositions mousePosition = Constants.MousePositions.None;
            if (mouseState.LeftButton.Equals(ButtonState.Pressed)){

                if (mouseState.X < Constants.GAME_WIDTH / 2 && mouseState.X >= 0)
                {
                    if (mouseState.Y < Constants.GAME_HEIGHT / 2 && mouseState.Y >= 0) { mousePosition = Constants.MousePositions.TopLeft; }
                    else if (mouseState.Y >= Constants.GAME_HEIGHT / 2 && mouseState.Y < Constants.GAME_HEIGHT) { mousePosition = Constants.MousePositions.BottomLeft; }
                }
                else if (mouseState.X >= Constants.GAME_WIDTH / 2 && mouseState.X < Constants.GAME_WIDTH)
                {
                    if (mouseState.Y < Constants.GAME_HEIGHT / 2 && mouseState.Y >= 0) { mousePosition = Constants.MousePositions.TopRight; }
                    else if (mouseState.Y >= Constants.GAME_HEIGHT / 2 && mouseState.Y < Constants.GAME_HEIGHT) { mousePosition = Constants.MousePositions.BottomRight; }
                }

            } else if (mouseState.RightButton.Equals(ButtonState.Pressed)) {
                mousePosition = Constants.MousePositions.RightClick;
            }

            return mousePosition;
        }

        public Constants.Actions currentState()
        {
            Constants.Actions action = Constants.Actions.Nothing;
            Constants.MousePositions mousePosition = generateMousePosition();

            dictionary.TryGetValue(mousePosition, out action);

            return action;
        }

        public ISprite getSprite(Constants.Actions action, ContentManager content)
        {
            ISprite sprite = null;

            switch (action)
            {
                case Constants.Actions.Display_OneFrame_Fixed:
                    sprite = new Sprite(content); break;
                case Constants.Actions.Display_Animated_Fixed:
                    sprite = new AnimatedSprite(content); break;
                case Constants.Actions.Display_OneFrame_Moves:
                    sprite = new MovingSprite(content); break;
                case Constants.Actions.Display_Animated_Moves:
                    sprite = new AnimatedMovingSprite(content); break;

                default: sprite = null; break;
            }

            return sprite;
        }

        public ISprite update(KeyboardState state, ContentManager content)
        {
            throw new NotImplementedException();
        }

        public ISprite update(MouseState state, ContentManager content)
        {
            mouseState = state;
            return getSprite(currentState(), content);
        }
    }
}
