using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSE3902_Sprint0.Sprites;
using Microsoft.Xna.Framework.Content;

namespace CSE3902_Sprint0.Controller
{
    public interface IController
    {
        public ISprite update(KeyboardState state, ContentManager content);
        public ISprite update(MouseState state, ContentManager content);
        public Constants.Actions currentState();
        public ISprite getSprite(Constants.Actions action, ContentManager content);
    }
}
