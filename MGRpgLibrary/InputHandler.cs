using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MGRpgLibrary
{
    class InputHandler : Microsoft.Xna.Framework.GameComponent
    {
        #region Field Region
        static KeyboardState keyboardState;
        static KeyboardState lastKeyboardState;
        #endregion

        #region Property Region
        public static KeyboardState KeyboardState
        {
            get { return keyboardState; }
        }

        public static KeyboardState LastKeyboardState
        {
            get { return lastKeyboardState; }
        }
    }
}
