using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.Projectiles;

namespace StudentProject.Code.GameObjects.Enemies
{
    class Fel_Hydra : GameObject
    {
        //sets enemey health to 3 and spawns in animation for the enemey sprite
        private int _health = 3;
        public Fel_Hydra()
        {
            SetSprite("Fel Hydra", 96, 0.1f, new int[] { 6 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
            AudioManager.Instance.PlaySFX("Dragon Roar", this, SFXOverlapRule.Overwrite);
        }
        //Update
        public override void Update(float deltaTime)
        {
            Fire();
            CheckCollisons();


        }
        //Fires a fire blast in the set direction at a random intervel
        private void Fire()
        {
            if (Core.GetRandomNumber(500) <= 0)
            {
                GetScreen().AddObject(new Fel_Fire_Blast(), (int)GetCenter().X, (int)GetCenter().Y);
            }
        }
        //Checks for a collison with the players throwing star ability, once the throwing star has reduced the enemies health to zero the object is removed
        private void CheckCollisons()
        {
            GameObject other = GetOneIntersectingObject<Throwing_Star>();
            if (other != null)
            {
                _health--;
                GetScreen().RemoveObject(other);
                if (_health <= 0)
                {
                    GetScreen().RemoveObject(this);


                }
            }
        }


    }
}
