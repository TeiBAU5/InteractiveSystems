using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CSE3902_Sprint0.Sprites
{
    public class TextSprite : ISprite
    {
        private string text; //What text to draw
        private int x;
        private int y;
        private SpriteFont font;

        public TextSprite(ContentManager content)
        {
            loadContent(content);
            Vector2 temp = font.MeasureString(text);
            this.x = Constants.DEFAULT_X - (int) temp.X / 2;
            this.y = Constants.DEFAULT_TEXT_Y - (int) temp.Y / 2;
        }

        public TextSprite(ContentManager content, int x, int y)
        {
            loadContent(content);
            Vector2 temp = font.MeasureString(text);
            this.x = x - (int) temp.X / 2;
            this.y = y - (int) temp.Y / 2;
        }

        public void loadContent(ContentManager content)
        {
            this.text = Constants.SPRITE_TEXT;
            this.font = content.Load<SpriteFont>(Constants.FONT_FILENAME);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, text, new Vector2(x, y), Constants.DEFAULT_TEXT_COLOR);
        }

        public void update()
        {
            //No implementation since this sprite does not change
        }
    }

}
