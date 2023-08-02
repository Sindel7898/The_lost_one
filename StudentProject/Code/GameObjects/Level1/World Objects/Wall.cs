using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{   
    //Creates the game object and sets the sprite for the game object wall
    class Wall : GameObject
    {
        public Wall()
        {
            SetSprite("Wall");
        }

        public override void Update(float deltaTime)
        {

        }
    }
}
