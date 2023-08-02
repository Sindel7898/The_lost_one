using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;
using MonoGameEngine;

namespace StudentProject.Code.GameObjects
{
    class BossBullet:GameObject
    {
        //sets th speed and timer 
        private int _speed = -2;
        private float _timer = 0.0f;
        public BossBullet()
        {
            // sets the enemy bullet 
            SetSprite("Enemy Bullet");
            GetSprite().SetOrigin(0.5f, 0.5f);
            GetSprite().SetLayerDepth(4);
        }

        /* constanly moves the position of the boss bullet down at a constant speed of 2 
            constanly checks if the boss bullet is on screen and if its not its removed from the world
        */
        public override void Update(float deltaTime)
        {
            SetPosition(GetX(), GetY() - _speed);
            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
            CheckCollision();

            //if the boss bullet is touching the grass keep it there for 2 seconds then removes it 
            if (IsTouching<Grass>())
            {
                RevertPosition();
                _timer += deltaTime;
                if (_timer >= 2.0)
                {
                    GetScreen().RemoveObject(this);

                }

            }

        }

        //checks if the boss bullet is touching dannifinal boss if it is remove the boss bullet from the world
        public void CheckCollision()
        {
            GameObject obj = GetOneIntersectingObject<BossBullet>();

            if (obj != null)
            {
                GetScreen().GetOneObjectOfType<DanniFinalBoss>();
                GetScreen().RemoveObject(this);
              
            }
        }

    }

}
