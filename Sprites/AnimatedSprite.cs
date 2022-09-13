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
    public class AnimatedSprite : ISprite
    {
        public Texture2D[] pictures;

        public int x;
        public int y;

        public AnimatedSprite(ContentManager content)
        {
            loadContent(content);

            x = Constants.DEFAULT_X - pictures[Game1.currentPicture].Width / 2;
            y = Constants.DEFAULT_Y - pictures[Game1.currentPicture].Height / 2;
        }

        public AnimatedSprite(ContentManager content, int x, int y)
        {
            loadContent(content);

            x = x - pictures[Game1.currentPicture].Width / 2;
            y = y - pictures[Game1.currentPicture].Height / 2;
        }

        public void loadContent(ContentManager content)
        {
            this.pictures = new Texture2D[Constants.ANIMATED_PICTURE_NAMES.Length];

            for (int i = 0; i < this.pictures.Length; i++)
            {
                this.pictures[i] = content.Load<Texture2D>(Constants.ANIMATED_PICTURE_NAMES[i]);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(pictures[Game1.currentPicture], new Vector2(x, y), Constants.DEFAULT_PICTURE_COLOR);
        }

        public void update()
        {
            Game1.currentPicture++;
            Game1.currentPicture %= pictures.Length;
        }
    }
}
