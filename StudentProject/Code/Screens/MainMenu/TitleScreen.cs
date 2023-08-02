using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentProject.Code.Screens
{
    public class TitleScreen : Screen
    {

        private float _timeRemaining = 3;
        public override void Start(Core core)
        {
            base.Start(core);
           

            SetBackground("titleScreen");
            AudioManager.Instance.PlayBGM("MenuMusic");
            AudioManager.Instance.PlayBGM("Intro");


        }

        //if time is equal to 3 the screen is transitioned to lost one text 
        public override void Update(float deltaTime)

        {
            base.Update(deltaTime);
            if (_timeRemaining > 0)
            {
                _timeRemaining -= deltaTime;
                if (_timeRemaining <= 0)
                {
                    _timeRemaining = 0;



                    Transition.Instance.ToScreen<LostOneText>(TransitionType.Fade);
                }



            }
        }
    }
}