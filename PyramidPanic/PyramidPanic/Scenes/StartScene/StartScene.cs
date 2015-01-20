﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace PyramidPanic
{
    public class StartScene : IState
    {
        //Fields
        private PyramidPanic game;
        private Image background;


        //Properties


        //Constructor
        public StartScene(PyramidPanic game)
        {
            this.game = game;
            this.background = new Image(this.game, @"StartScenePics\Background", Vector2.Zero);

        }

        // Update
        public void Update(GameTime gameTime)
        {

        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.SandyBrown);
            this.background.Draw(gameTime);
        }
    }
}