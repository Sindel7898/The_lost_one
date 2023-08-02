using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{
    class Grass : GameObject
    {
        /*sets sprite for grass  */
        public Grass()
        {
            SetSprite("Grass");
        }

        public override void Update(float deltaTime)
        {

        }
    }
}
