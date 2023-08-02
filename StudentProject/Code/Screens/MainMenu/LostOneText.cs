using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.Screens
{
    class LostOneText : Screen

    {
        private float _timeRemaining = 3.0f;

        public override void Start(Core core)
        {
            base.Start(core);

            Transition.Instance.EndTransition();
            SetBackground("titleScreen2");





        }

        //if the time is equal to 12 transition the screen the main menu 
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            if (_timeRemaining > 0)
            {
                _timeRemaining -= deltaTime;
                if (_timeRemaining <= 0)
                {
                    _timeRemaining = 0;

                    Transition.Instance.ToScreen<MainMenu>(TransitionType.Fade);




                }
            }
        }
    }
}