using MonoGameEngine.StandardCore;
using MonoGameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using StudentProject.Code.Screens;

namespace StudentProject.Code.GameObjects
{

    class BadTwo : GameObject
    {
        private float _timer = 0f;
        private bool _timerTrueFalse = false;
    

        public BadTwo()
        {
            SetSprite("bald");


        }
        public override void Update(float deltaTime)
        {
            Move();
            _timer += deltaTime;
           
        }




        // Code that moves the Bad Guys Left and Right Or Up And Down
        private void Move()
        {
            if (_timerTrueFalse == false)
            {
                SetPosition(GetX(), GetY() + 5);
                SetSprite("baldback", 19, 48, 0.05f, new int[] { 5 });
            }
            if (_timerTrueFalse == true)
            {
                SetPosition(GetX(), GetY() - 5);
                SetSprite("bald");
            }

            if (_timer >= 0.6)
            {
                if (_timerTrueFalse == false)
                {
                    _timerTrueFalse = true;
                    
                }
                else if (_timerTrueFalse == true)
                {
                    _timerTrueFalse = false;
                    
                }
                _timer = 0;
            }
        }
       
    }
    
}

