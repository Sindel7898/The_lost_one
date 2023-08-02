using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;


namespace StudentProject.Code.Screens
{
    public class GameOverMenu : Screen
    {
        Mouse _mouse;

        public override void Start(Core core)
        {
            base.Start(core);
            // TODO: Add your Screen starting code below here

            SetBackground("Boss Background");
            Transition.Instance.EndTransition();
            Transition.Instance.EndTransition();


            AddObject(new GameOver(), 740, 140);
            AddObject(new MainMenuButton(), 850, 300);
            AddObject(new PurpleCredits(), 850, 500);

            /* gets the position of the mouse and attaches the mouse object to it */
            _mouse = new Mouse();
            AddObject(_mouse, 0, 0);
            GameInput.SetMousePosition(core.GraphicsDevice.Viewport.Bounds.Center.ToVector2());
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);


        }

    }
}