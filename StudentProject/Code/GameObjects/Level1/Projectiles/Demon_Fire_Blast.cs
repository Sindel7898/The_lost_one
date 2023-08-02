using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects.Projectiles
{

    //Enemey projectiles that sets the speed of it to 2 and fires it in the x axis, cycling through the animation
    class Demon_Fire_Blast : GameObject
    {
        private int _speed = 2;

        public Demon_Fire_Blast()
        {
            AudioManager.Instance.PlaySFX("FireBall", this, SFXOverlapRule.Overwrite);
            SetSprite("Demon_Fire_Blast", 32, 0.5f, new int[] { 4 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
            GetSprite().SetOrigin(0.25f, 0.25f);
            GetSprite().SetLayerDepth(4);
        }

        //Removes object from screen once collided with the screen edge
        public override void Update(float deltaTime)
        {
            SetPosition(GetX() - _speed, GetY());

            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
        }
    }
}
