
using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.Screens;

namespace StudentProject.Code.GameObjects
{
    class SpellBook : GameObject
    {

        public SpellBook()
        {
            //sets sprite
            SetSprite("SpellBook");


            GetSprite().SetOrigin(0.5f, 0.5f);
        }
        public override void Update(float delta)
        {
            SetPosition(GameInput.GetMousePosition());
          

           


        }
 


    }
}
//SetVisible()