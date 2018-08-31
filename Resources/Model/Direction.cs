using System;
using SwinGameSDK;
using static SwinGameSDK.SwinGame;

/// <summary>
/// The direction the ship can be oriented.
/// </summary>

namespace MyGame
{
    public enum Direction
    {
        /// <summary>
        /// The ship is oriented left/right
        /// </summary>
        LeftRight,

        /// <summary>
        /// The ship is oriented up/down
        /// </summary>
        UpDown
    }
}