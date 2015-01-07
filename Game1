using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace test
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        KeyboardState key, oldkey;

        Player mario;

        Rectangle[] ground = new Rectangle[400];

        Texture2D bkg;
        Rectangle bkgR, screen;
        Texture2D soil, mystery, action;
        Texture2D soilCL, soilCR;
        Rectangle[] mBox = new Rectangle[5];
        Rectangle[] aBox = new Rectangle[10];
        Rectangle groundCR, groundCL;
        Vector2 marioPos;
        Texture2D marioPic;

        int boxesLvl = 320;
        int groundLvl = 380;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 400;
            graphics.PreferredBackBufferWidth = 600;
            Content.RootDirectory = "Content";

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;


            for (int i = 0; i < ground.Length - 1; i++)
            {
                ground[i] = new Rectangle(i * 10, groundLvl, 20, 20);
            }

            groundCR = new Rectangle(300, groundLvl, 20, 20);
            groundCL = new Rectangle(340, groundLvl, 20, 20);

            mBox[0] = new Rectangle(100, boxesLvl, 20, 20);
            mBox[1] = new Rectangle(530, boxesLvl, 20, 20);
            mBox[2] = new Rectangle(550, boxesLvl, 20, 20);
            mBox[3] = new Rectangle(800, boxesLvl, 20, 20);
            mBox[4] = new Rectangle(1200, boxesLvl, 20, 20);

            aBox[0] = new Rectangle(490, boxesLvl, 20, 20);
            aBox[1] = new Rectangle(510, boxesLvl, 20, 20);
            aBox[2] = new Rectangle(570, boxesLvl, 20, 20);

            bkgR = new Rectangle(0, 0, 1560, 400);
            screen = new Rectangle(0, 0, 600, 400);

            marioPos = new Vector2(5, 345); //345 is ground level for player

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            bkg = Content.Load<Texture2D>("Untitled-1");
            soil = Content.Load<Texture2D>("topSoil");
            mystery = Content.Load<Texture2D>("mysteryBox");
            action = Content.Load<Texture2D>("actionBox");
            soilCL = Content.Load<Texture2D>("cornerSoilL");
            soilCR = Content.Load<Texture2D>("cornerSoilR");
            marioPic = Content.Load<Texture2D>("marioStandR");

            mario = new Player(marioPos, marioPic);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            key = Keyboard.GetState();
            
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            mario.Update(key, oldkey, ground);

            oldkey = key;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(bkg, bkgR, Color.White);

            for (int i = 0; i < ground.Length - 1; i++)
            {
                spriteBatch.Draw(soil, ground[i], Color.White);
            }

            for (int i = 0; i < mBox.Length - 1; i++)
            {
                spriteBatch.Draw(mystery, mBox[i], Color.White);
            }

            for (int i = 0; i < 3; i++)
            {
                spriteBatch.Draw(action, aBox[i], Color.White);
            }

            mario.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
