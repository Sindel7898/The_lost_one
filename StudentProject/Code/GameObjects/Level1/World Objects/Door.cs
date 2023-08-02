using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects.World_Objects
{   //Sets game object for door and sets sprite
    class Door : GameObject
    {
        public Door()
        {
            SetSprite("DoorLevel1");
        }
        public override void Update(float deltaTime)
        {
            
        }
    }
}
