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
    public class Player : Game1
    {
        private Rectangle characterPos;
        public Rectangle CharacterPos
        {
            get { return characterPos; }
            set { characterPos = value; }
        }

        private Texture2D player;

        bool hasJumped;

        private Vector2 position;
        private Vector2 velocity;
        private bool gravity;

        public Player()
        {
            characterPos = new Rectangle(5, 345, 20, 35);
            velocity = new Vector2(0, 0);
        }

        public Player(Vector2 position, Texture2D pic)
        {
            //draw that man
            characterPos = new Rectangle((int)position.X, (int)position.Y, 20, 35);
            player = pic;
            velocity = new Vector2(0, 0);
        }

        public void Update(KeyboardState keys, KeyboardState oldkeys, Rectangle[] ground)
        {
            //Bring the player down
            position.Y += 3.0f;

            //Movement Logic
            if (keys.IsKeyDown(Keys.Right))
            {
                position.X += 3.0f;
            }

            if (keys.IsKeyDown(Keys.Left))
            {
                position.X -= 3.0f;
            }

            if (keys.IsKeyDown(Keys.Up))
            {
                position.Y -= 15.0f;
            }

            

            characterPos.X = (int)position.X;
            characterPos.Y = (int)position.Y;

            GroundCollision(ground);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(player, characterPos, Color.White);
        }

        public void GroundCollision(Rectangle[] groundArr)
        {
            for (int i = 0; i < groundArr.Length - 1; i++)
            {
                if (characterPos.Intersects(groundArr[i]))
                {
                    position.Y = 343;
                }
                else
                {
                    velocity.Y = 3.0f;
                }
            }
        }
    }
}
