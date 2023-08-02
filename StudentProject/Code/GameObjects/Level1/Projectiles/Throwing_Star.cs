using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects.Projectiles
{

    class Throwing_Star : GameObject
    {
        //Enemey projectiles that sets the speed of it to 5 and fires it in the x axis, cycling through the animation
        private int _speed = 5;
        public Throwing_Star()
        {
            SetSprite("Throwing Star", 32, 0.5f, new int[] { 4 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
            GetSprite().SetOrigin(0.5f, 0.5f);
            GetSprite().SetLayerDepth(4);
        }
        //Removes object from screen once collided with the screen edge
        public override void Update(float deltaTime)
        {
            SetPosition(GetX() + _speed, GetY() );

            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
        }
    }
}
