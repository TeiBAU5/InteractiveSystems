using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using CSE3902_Sprint0.Sprites;
using Microsoft.Xna.Framework.Content;

namespace CSE3902_Sprint0.Controller
{
    public class KeyboardController : IController
    {
        KeyboardState keyboardState;
        Dictionary<Keys, Constants.Actions> dictionary;

        public KeyboardController()
        {
            createDictionary();
        }

        private void createDictionary()
        {
            dictionary = new Dictionary<Keys, Constants.Actions>
            {
                { Constants.QUIT_KEY, Constants.Actions.Quit },
                { Constants.QUIT_KEY_NUMPAD, Constants.Actions.Quit },

                { Constants.DOFF_KEY,  Constants.Actions.Display_OneFrame_Fixed},
                { Constants.DOFF_KEY_NUMPAD, Constants.Actions.Display_OneFrame_Fixed },

                { Constants.DAF_KEY, Constants.Actions.Display_Animated_Fixed},
                { Constants.DAF_KEY_NUMPAD, Constants.Actions.Display_Animated_Fixed },

                { Constants.DOFM_KEY, Constants.Actions.Display_OneFrame_Moves },
                { Constants.DOFM_KEY_NUMPAD, Constants.Actions.Display_OneFrame_Moves },

                { Constants.DAM_KEY, Constants.Actions.Display_Animated_Moves },
                { Constants.DAM_KEY_NUMPAD, Constants.Actions.Display_Animated_Moves }
            };
        }

        public Constants.Actions currentState()
        {
            Constants.Actions action = Constants.Actions.Nothing;
            
            foreach(Keys key in dictionary.Keys)
            {
                if (keyboardState.IsKeyDown(key))
                {
                    dictionary.TryGetValue(key, out action);
                }
            }

            return action;
        }

        public ISprite getSprite(Constants.Actions action, ContentManager content)
        {
            ISprite sprite = null;

            switch (action) {
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
            keyboardState = state;
            return getSprite(currentState(), content);
        }

        public ISprite update(MouseState state, ContentManager content)
        {
            throw new NotImplementedException();
        }
    }
}
