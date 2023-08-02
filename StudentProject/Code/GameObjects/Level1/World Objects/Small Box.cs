using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{   //Creates a game object and sets sprite for the small box
    class SmallBox : GameObject
    {
        public SmallBox()
        {
            SetSprite("Wooden Box small Sprite");
        }
        public override void Update(float deltaTime)
        {

        }
    }
}
