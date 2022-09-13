using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0.Sprites
{
    public class Sprite : ISprite
    {
        Texture2D picture;
        public int x;
        public int y;

        public Sprite(ContentManager content)
        {
            loadContent(content);
            x = Constants.DEFAULT_X - picture.Width / 2;
            y = Constants.DEFAULT_Y - picture.Height / 2;
        }

        public Sprite(ContentManager content, int x, int y)
        {
            loadContent(content);
            this.x = x - picture.Width / 2;
            this.y = y - picture.Height / 2;
        }

        public void loadContent(ContentManager content)
        {
            this.picture = content.Load<Texture2D>(Constants.ANIMATED_PICTURE_NAMES[Game1.currentPicture]);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.picture, new Vector2(this.x, this.y), Constants.DEFAULT_PICTURE_COLOR);
        }

        public void update()
        {
            //No implementation since this sprite does not change
        }
    }
}
