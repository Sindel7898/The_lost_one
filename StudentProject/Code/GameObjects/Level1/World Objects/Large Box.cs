using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using StudentProject.Code.GameObjects.Projectiles;

namespace StudentProject.Code.GameObjects.World_Objects
{   //Creates object for large box and sets the sprite
    class Large_Box : GameObject
    {
        public Large_Box()
        {
            SetSprite("Wooden Box large Sprite");
        }
        public override void Update(float deltaTime)
        {
            CheckCollisons();
        }
        //removes the throwing star object when it collides with the box
        private void CheckCollisons()
        {
            GameObject othe = GetOneIntersectingObject<Throwing_Star>();
            if (othe != null)
            {
                GetScreen().RemoveObject(othe);
            }
        }
    }
}
