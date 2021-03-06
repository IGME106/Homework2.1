﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Homework 2 - Coin Collector
/// Class Description   : GameObject class for creation of the game objects
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 19, 2018
/// Filename            : GameObject.cs
/// </summary>
///

namespace Homework2
{
    /// <summary>
    /// Class file for the game objects
    /// </summary>
    class GameObject : Game1
    {
        private Texture2D objectTexture;
        private Rectangle rectangle;

        private int xPosition;
        private int yPosition;

        /// <summary>
        /// Player object constructor.  Takes input values and creates the object
        /// </summary>
        /// <param name="x">player x coordinate</param>
        /// <param name="y">player y coordinate</param>
        /// <param name="width">sprite width</param>
        /// <param name="height">sprite height</param>
        /// 
        public GameObject(int x, int y, int width, int height)
        {
            this.Rectangle = new Rectangle(x, y, width, height);
        }

        /// <summary>
        /// Property of sprite texture / image
        /// </summary>
        public Texture2D ObjectTexture
        {
            get { return this.objectTexture; }
            set { this.objectTexture = value; }
        }

        /// <summary>
        /// Property of rectangle containing sprite
        /// </summary>
        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            set { this.rectangle = value; }
        }

        /// <summary>
        /// Property of x coordinate of object
        /// </summary>
        public int XPosition
        {
            get { return this.xPosition; }
            set
            {
                this.xPosition = value;

                this.CreateRectangle();                                              // rectangle is a struct, therefore it
            }                                                                       // has to be recreated
        }

        /// <summary>
        /// Property of y coordinate of object
        /// </summary>
        public int YPosition
        {
            get { return this.yPosition; }
            set
            {
                this.yPosition = value;

                this.CreateRectangle();                                              // rectangle is a struct, therefore it
            }                                                                       // has to be recreated
        }

        /// <summary>
        /// Recreate the rectangle element.  Called if a property is changed.
        /// </summary>
        private void CreateRectangle()
        {
            this.Rectangle = new Rectangle(this.XPosition, this.YPosition, this.Rectangle.Width, this.Rectangle.Height);
        }

        /// <summary>
        /// Property of previous statemachine state of the sprite
        /// </summary>
        public void Draw(SpriteBatch spriteBatch)
        {   
            spriteBatch.Draw(
                this.ObjectTexture,
                this.Rectangle,
                Color.White);
        }
    }    
}
