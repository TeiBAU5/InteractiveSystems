using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902_Sprint0
{
    public class Constants
    {
        //All necessary constants are stored here for ease of change.
        public enum Actions
        {
            Quit,
            Display_OneFrame_Fixed,
            Display_Animated_Fixed,
            Display_OneFrame_Moves,
            Display_Animated_Moves,
            Nothing
        }

        public const Keys QUIT_KEY = Keys.D0;
        public const Keys QUIT_KEY_NUMPAD = Keys.NumPad0;
        public const Keys DOFF_KEY = Keys.D1;              //DOFF = Display One Frame Fixed
        public const Keys DOFF_KEY_NUMPAD = Keys.NumPad1;
        public const Keys DAF_KEY = Keys.D2;               //DAF = Display Animated Fixed
        public const Keys DAF_KEY_NUMPAD = Keys.NumPad2;
        public const Keys DOFM_KEY = Keys.D3;              //DOFM = Display One Frame Moves
        public const Keys DOFM_KEY_NUMPAD = Keys.NumPad3;
        public const Keys DAM_KEY = Keys.D4;               //DAM = Display Animated Moves
        public const Keys DAM_KEY_NUMPAD = Keys.NumPad4;

        public enum MousePositions
        {
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight,
            RightClick,
            None
        }

        public const MousePositions QUIT_MOUSE = MousePositions.RightClick;
        public const MousePositions DOFF_POS_MOUSE = MousePositions.TopLeft;
        public const MousePositions DAF_POS_MOUSE = MousePositions.TopRight;
        public const MousePositions DOFM_POS_MOUSE = MousePositions.BottomLeft;
        public const MousePositions DAM_POS_MOUSE = MousePositions.BottomRight;

        public const String SPRITE_TEXT = "Credits\nProgram Made By: Aubert Li\nSprites from: https://eclipserpg.com/images/";
        public const String FONT_FILENAME = "Fonts";
        public const String DEFAULT_PICTURE_NAME = "sprite_00";

        public static String[] ANIMATED_PICTURE_NAMES = new String[] { "sprite_00", "sprite_01", "sprite_02", "sprite_03", "sprite_04", "sprite_05", "sprite_06", "sprite_07",
            "sprite_08", "sprite_09", "sprite_10", "sprite_11", "sprite_12", "sprite_13", "sprite_14", "sprite_15", "sprite_16", "sprite_17", "sprite_18", "sprite_19", 
            "sprite_20", "sprite_21", "sprite_22", "sprite_23", "sprite_24", "sprite_25", "sprite_26", "sprite_27", "sprite_28", "sprite_29", "sprite_30", "sprite_31", 
            "sprite_32", "sprite_33", "sprite_34", "sprite_35", "sprite_36", "sprite_37", "sprite_38", "sprite_39", "sprite_40", "sprite_41", "sprite_42", "sprite_43", 
            "sprite_44", "sprite_45", "sprite_46", "sprite_47", "sprite_48", "sprite_49", "sprite_50", "sprite_51", "sprite_52", "sprite_53", "sprite_54", "sprite_55", 
            "sprite_56", "sprite_57", "sprite_58" };

        public const int GAME_WIDTH = 800;
        public const int GAME_HEIGHT = 480;

        public const int DEFAULT_X = GAME_WIDTH / 2;
        public const int DEFAULT_Y = GAME_HEIGHT / 2;
        public const int DEFAULT_TEXT_Y = 3 * GAME_HEIGHT / 4;
        public const int DEFAULT_X_SPEED = GAME_WIDTH / 100;
        public const int DEFAULT_Y_SPEED = GAME_HEIGHT / 100;

        public static Color DEFAULT_PICTURE_COLOR = Color.White;
        public static Color DEFAULT_TEXT_COLOR = Color.Black;
    }
}
