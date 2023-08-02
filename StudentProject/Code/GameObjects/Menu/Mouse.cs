
using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.Screens;

namespace StudentProject.Code.GameObjects
{
    class Mouse : GameObject
    {
        //sets sprite
        public Mouse()
        {

            SetSprite("Mouse");


            GetSprite().SetOrigin(0.5f, 0.5f);
        }
        public override void Update(float delta)
        {
            SetPosition(GameInput.GetMousePosition());
            if (GameInput.IsMouseButtonPressed(MouseButton.Left))
            {
     
                
                CheckMainMenuCollision();
                CheckCollision();
                CheckCreditCollision();
                CheckBackCollision();
                CheckControlCollision();
                CheckEndCreditCollision();
            }
        }

        /*checks if the mouse interacts with the purple credits 
        if it does a click sound effect is played then it transitions the screen to the credit screen */
        private void CheckEndCreditCollision()
        {
            GameObject obj1 = GetOneObjectAtOffset<PurpleCredits>(0, 0);

            if (obj1 != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
               Transition.Instance.ToScreen<CreditScreen>(TransitionType.Fade);

            }
        }

        /* checks if the mouse interacts with the menu button and if it does the click sound effect is played 
        then the screen is transitioned to the main menu screen */
        private void CheckMainMenuCollision()
        {
            GameObject obj1 = GetOneObjectAtOffset<MainMenuButton>(0, 0);

            if (obj1 != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
               Transition.Instance.ToScreen<MainMenu>(TransitionType.Fade);

            }
        }

        /* checks if the mouse interacts with the start button when it does a click sound effect is played
        then the screen is transitioned to Level 1 and the boss level */
        private void CheckCollision()
        {
            GameObject obj = GetOneObjectAtOffset<Start>(0, 0);

            if (obj != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
                Transition.Instance.ToScreen<Level_1>(TransitionType.Fade);
                AudioManager.Instance.PlayBGM("Level1");

            }
        }

        /*checks if the mouse interacts with the credits and if it does  a click sound effect would be player
        and the screen will transition to credis screen */
        private void CheckCreditCollision()
        {
            GameObject obj1 = GetOneObjectAtOffset<Credits>(0, 0);

            if (obj1 != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
                Transition.Instance.ToScreen<CreditScreen>(TransitionType.Fade);

            }
        }

        /* checks if the mouse interacts with the back button and
        if it does playy click sound effect and transition back to main menu */

        private void CheckBackCollision()
        {
            GameObject obj1 = GetOneObjectAtOffset<Back>(0, 0);

            if (obj1 != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
                Transition.Instance.ToScreen<MainMenu>(TransitionType.Fade);

            }
        }

        /* checks if the mouse interacts with the control button and 
        if it does a click sound effect is played and the screen transitions to control screen  */
        private void CheckControlCollision()
        {
            GameObject obj1 = GetOneObjectAtOffset<Control>(0, 0);

            if (obj1 != null)
            {
                AudioManager.Instance.PlaySFX("Click", this, SFXOverlapRule.Overwrite);
                Transition.Instance.ToScreen<ControlScreen>(TransitionType.Fade);

            }
        }


    }
}