using MonoGameEngine.StandardCore;
using MonoGameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using StudentProject.Code.Screens;

namespace StudentProject.Code.GameObjects
{

    class Bad : GameObject
    {
        private float _timer = 0f;
        private bool _timerTrueFalse = false;
  
        
        public Bad()
        {
            SetSprite("baldleftright", 19, 48, 0.05f, new int[] { 5 });
           
            
    }
        public override void Update(float deltaTime)
        {
            Move();
            _timer += deltaTime;
           // Playercollision();
        }
        // Code that moves the Bad Guys Left and Right Or Up And Down
        private void Move()
        {
            if(_timerTrueFalse == false)
            {
                SetPosition(GetX() + 2, GetY());
            }
            if(_timerTrueFalse == true)
            {
                SetPosition(GetX() - 2, GetY());
            }

            if(_timer >= 1)
            {
                if(_timerTrueFalse == false)
                {
                    _timerTrueFalse = true;
                    SetSprite("baldrightleft", 19, 48, 0.05f, new int[] { 5 });
                }
                else if(_timerTrueFalse == true)
                {
                    _timerTrueFalse = false;
                    SetSprite("baldleftright", 19, 48, 0.05f, new int[] { 5 });
                }
                _timer = 0;
            }

               
     

        }

      
    }

}
