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
    struct Circle
    {
        public Vector2 Center;
        public float Radius;


        public Circle(Vector2 position, float radius)
        {
            Center = position;
            Radius = radius;
        }

        public bool Intersects(Rectangle rect)
        {
            Vector2 v = new Vector2(MathHelper.Clamp(Center.X, rect.Left, rect.Right),
                MathHelper.Clamp(Center.Y, rect.Top, rect.Bottom));

            Vector2 direction = Center - v;
            float distanceSquared = direction.LengthSquared();

            return ((distanceSquared > 0) && (distanceSquared < Radius * Radius));
        }

        public Vector2 Right(Circle circ)
        {
            return new Vector2(circ.Center.X + Radius, circ.Center.Y);
        }

        public Vector2 Left(Circle circ)
        {
            return new Vector2(circ.Center.X - Radius, circ.Center.Y);
        }

        public Vector2 Top(Circle circ)
        {
            return new Vector2(circ.Center.X, circ.Center.Y - Radius);
        }

        public Vector2 Bottom(Circle circ)
        {
            return new Vector2(circ.Center.X, circ.Center.Y + Radius);
        }
    }
}
