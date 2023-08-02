using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;
using MonoGameEngine;

namespace StudentProject.Code.GameObjects
{
    class Boss : GameObject
    {
        //sets the bosses health to 10 
        public int _Enemylives = 10;
        private bool _rising;
        private int _currentFrame;

        public Boss()
        {
            //sets the bosses sprite to be annimated by changing the frame 5 times 
            SetSprite("Boss", 480, 423, 0.1f, new int[] { 5 });
            SetVelocity((25 - Core.GetRandomNumber(51)) / 10.0f, 1 + Core.GetRandomNumber(1));

        }
        public override void Update(float deltaTime)
        {
            Move();
            CheckCollision();
            BulletSpawn();
            CheckForObstacle();
            CheckCollisions();
            CheckEnemydead();

           
        }

        private void Move()
        {
            //checks for a random number
            int movedirection = Core.GetRandomNumber(100);
            switch (movedirection)
            {
                case 0: //move right
                    SetPosition(GetX() + 100, GetY());
                    break;
                case 1: //move left
                    SetPosition(GetX() - 100, GetY());
                    break;

            }
            if (IsAtScreenEdge())
                RevertPosition();
         

        }

        //gets a randome number and if its 70 it spawns a boss bullet 
        private void BulletSpawn()
        {
            if (Core.GetRandomNumber(70) <= 0)
            {
                GetScreen().AddObject(new BossBullet(), (int)GetX() + 240 , (int)GetY() + 240);
            }
        }

        private void CheckCollision()
        {
            if (IsAtScreenEdge())
            {
                SetVelocity(GetVelocity().X * -1, GetVelocity().Y);
            }

            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
        }

        private void CheckForObstacle()
        {
            //checks if the boss is touching the grass it reverts the position 
            if (IsAtScreenEdge() || IsTouching<Grass>())
                RevertPosition();
        }

        private void CheckCollisions()
        {
            /* checks if the bullet comes incontact with the boss
              if the boss comes in contact with e bulet the bullet is removed 
            */
            GameObject obj = GetOneIntersectingObject<Bullet>();
            if (obj != null)
            {
                GetScreen().RemoveObject(obj);

                Shake();
                if (_Enemylives <= 0)
                {
                    //if the enemies lives is equal to or less than 0 remove the object and setenemyhealth
                    GetScreen().RemoveObject(this);
                    EnemyHealthDisplay enemyHealthDisplay = GetScreen().GetOneObjectOfType<EnemyHealthDisplay>();
                    enemyHealthDisplay.SetEnemyHealth(0);
                }
                else
                {
                   
                    EnemyHealthDisplay enemyHealthDisplay = GetScreen().GetOneObjectOfType<EnemyHealthDisplay>();
                    enemyHealthDisplay.SetEnemyHealth(_Enemylives);
                }
                //add 100 to the score and minus one from enemy lives 
                GetScreen().GetOneObjectOfType<DanniFinalBoss>().AddScore(100);
                _Enemylives--;
            
            }

            if (IsAtScreenEdge() || IsTouching<Grass>())
                RevertPosition();
        }
        

        private void CheckEnemydead()
        {
            /*checks if the bosses health is = 0 and if its = 0
            the boss death sound effect plays and the boss is removed */
            if (_Enemylives == 0)
            {
                AudioManager.Instance.PlaySFX("BossDeath", this, SFXOverlapRule.Overwrite);
                GetScreen().RemoveObject(this);
            }
        }

        //gets the enemieslives
        public int GetEnemylives()
        {
            return _Enemylives;
        }

        //shakes screen 
        public void Shake()
        {
            GetScreen().AddObject(new SpellBook(), (int)GetCenter().X, (int)GetCenter().Y);
            Camera2D.Instance.Shake(4.0f, 0.25f);
            _rising = true;
            _currentFrame = 0;
            GetSprite();
        }

    }
}