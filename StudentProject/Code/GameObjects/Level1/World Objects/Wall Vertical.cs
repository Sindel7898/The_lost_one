using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.Pickups;
using StudentProject.Code.GameObjects.Projectiles;

namespace StudentProject.Code.GameObjects.World_Objects
{   //Creates game object and sets sprite for vertical wall
    class Wall_Vertical : GameObject
    {
        public Wall_Vertical()
        {
            SetSprite("wallv");
        }
        public override void Update(float deltaTime)
        {
            CheckCollisons();
        }
        //Checks for the collisions of the fel fire blast and throwing star and removes the objects
        private void CheckCollisons()
        {
            GameObject other = GetOneIntersectingObject<Fel_Fire_Blast>();
            if (other != null)
            {
                GetScreen().RemoveObject(other);

            }
            GameObject othe = GetOneIntersectingObject<Throwing_Star>();
            if (othe != null)
            {
                GetScreen().RemoveObject(othe);
            }
        }
    }
}
