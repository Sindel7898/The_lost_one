using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{
    class GameOver : GameObject
    {
        //sets sprite
        public GameOver()
        {
            SetSprite("Game over");
        }

        public override void Update(float deltaTime)
        {

        }
    }
}


