using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{   //Creates game object for the platform and sets sprite
    class Platform : GameObject
    {
        public Platform()
        {
            SetSprite("Platform");
        }
        public override void Update(float deltaTime)
        {

        }
    }
}
