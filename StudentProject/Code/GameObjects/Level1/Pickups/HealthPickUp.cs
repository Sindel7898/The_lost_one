using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.World_Objects;

namespace StudentProject.Code.GameObjects.Pickups
{
    class HealthPickUp : GameObject
    {
        //Sets a timer for 0 and sets the player sprite and speed at which the heart drops
        private float _timer = 0.0f;
        public HealthPickUp()
        {
            SetSprite("Player health");
            GetSprite().SetInWorldSpace(false);
            SetVelocity((25 - Core.GetRandomNumber(51)) / 10.0f, 1 + Core.GetRandomNumber(1));
            
        }
        //Update, includes a timer which removes the object after the alotted time
        public override void Update(float deltaTime)
        {
            Move();
            CheckCollisions();
            CheckForObstacles();
            if (IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
            {
                RevertPosition();
                _timer += deltaTime;
                if (_timer >= 3.0)
                {
                    GetScreen().RemoveObject(this);
                }
            }
        }
        //Sets position and speed
        private void Move()
        {
            SetPosition(GetPosition() + GetVelocity());
        }
        //Checks to see if the object collides with the screen edge, removes it if it goes off screen
        private void CheckCollisions()
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
        //checks if it is touching the obstacles
        private void CheckForObstacles()
        {
            if (IsAtScreenEdge() || IsTouching<Wall>())
                RevertPosition();
        }
    }
}
