using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects.Level2.BadGuys
{

    class Bad4 : GameObject
    {
        private float _timer = 0f;
        private bool _timerTrueFalse = false;


        public Bad4()
        {
            SetSprite("baldleftright", 19, 48, 0.05f, new int[] { 5 });


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
                SetPosition(GetX() + 5, GetY());
            }
            if (_timerTrueFalse == true)
            {
                SetPosition(GetX() - 5, GetY());
            }

            if (_timer >= 1.6)
            {
                if (_timerTrueFalse == false)
                {
                    _timerTrueFalse = true;
                    SetSprite("baldrightleft", 19, 48, 0.05f, new int[] { 5 });
                }
                else if (_timerTrueFalse == true)
                {
                    _timerTrueFalse = false;
                    SetSprite("baldleftright", 19, 48, 0.05f, new int[] { 5 });
                }
                _timer = 0;
            }





        }

      
    }
}
