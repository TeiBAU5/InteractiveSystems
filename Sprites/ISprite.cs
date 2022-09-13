using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0.Sprites
{
    public interface ISprite
    {
        public void Draw(SpriteBatch spriteBatch);
        public void update();
        public void loadContent(ContentManager content);
    }
}
