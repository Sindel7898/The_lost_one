using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{
    // Define a class called Bonus that inherits from GameObject
    class Bonus : GameObject
    {
        // Define two private fields: _speed and _timer
        private int _speed = -2;
        private float _timer = 0.0f;

        // Define the constructor for the Bonus class
        public Bonus()
        {
            // Set the sprite for the bonus object
            SetSprite("Player health");

            // Set the origin of the sprite to be at the center of the object
            GetSprite().SetOrigin(0.5f, 0.5f);

            // Set the layer depth of the sprite to be 4
            GetSprite().SetLayerDepth(4);
        }

        // Define the Update method for the Bonus class
        public override void Update(float deltaTime)
        {
            // Move the bonus object up the screen by _speed amount
            SetPosition(GetX(), GetY() - _speed);

            // Remove the object if it is off the screen
            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }

            // Check for collisions with other objects
            CheckCollisions();

            // If the bonus is touching the grass object, keep it there for 6 seconds, then remove it
            if (IsTouching<Grass>())
            {
                RevertPosition(); // Move the object back to where it was before it touched the grass
                _timer += deltaTime; // Increment the timer by the amount of time passed since the last update
                if (_timer >= 6.0) // If the timer has reached 6 seconds, remove the object
                {
                    GetScreen().RemoveObject(this);
                }
            }
        }

        // Define a private method called CheckCollisions to handle collisions with other objects
        private void CheckCollisions()
        {
            // If the object is at the edge of the screen, reverse its horizontal velocity
            if (IsAtScreenEdge())
            {
                SetVelocity(GetVelocity().X * 1 - 1, GetVelocity().Y);
            }

            // If the object is off the screen, remove it
            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
        }
    }
}