using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.Projectiles;
using StudentProject.Code.GameObjects.World_Objects;

namespace StudentProject.Code.GameObjects.Enemies
{
    //Sets the enemies health and speed, also sets the sprite animation for the enemey
    class Ninja_Spear : GameObject
    {
        private int _speed = 1;
        private int _health = 2;

        public Ninja_Spear()
        {
            SetSprite("Ninja_Spear_Running_Left", 96, 0.1f, new int[] { 5 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
        }

        //Update
        public override void Update(float deltaTime)
        {
            Movement();
            CheckCollisons();
            ValidateMovement();
        }
        //Checks to see if the enemey is touching the large box, if so it reverts its position
        private void CheckForObstacles()
        {
                if (IsTouching<Large_Box>())
                RevertPosition();
        }
        //Sets the enemies direction based on if it touches the large box, it reverts its position in the opposite direction
        private void Movement()
        {
            int moveDirection = _speed;
            switch (moveDirection)
            {
                case 0:
                    SetPosition(GetX() + _speed, GetY());
                    if (IsTouching<Large_Box>())
                        RevertPosition();
                    break;
                case 1:
                    SetPosition(GetX() - _speed, GetY());
                    if (IsTouching<Large_Box>())
                        RevertPosition();
                    break;
               
            }

            CheckForObstacles();
            ValidateMovement();
        }
        //Another check for the enemies movement
        private void ValidateMovement()
        {
            if (IsAtScreenEdge() == true)
            {
                RevertPosition();
            }
            if (IsTouching<Large_Box>() == true)
            {
                RevertPosition();
            }
            
        }
        //Checks to see if the player's throwing star ability has hit the enemey, doing so reduces the enemies health to zero and remove the object
        private void CheckCollisons()
        {
            GameObject other = GetOneIntersectingObject<Throwing_Star>();
            if (other != null)
            {
                AudioManager.Instance.PlaySFX("Ninja", this, SFXOverlapRule.Overwrite);
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
