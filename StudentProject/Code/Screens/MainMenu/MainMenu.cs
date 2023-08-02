using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;

namespace StudentProject.Code.Screens
{
    public class MainMenu : Screen
    {
        Mouse _mouse;

        public override void Start(Core core)
        {
            base.Start(core);
            // TODO: Add your Screen starting code below here
            Transition.Instance.EndTransition();

            Settings.BackgroundFill = Color.White;
            Settings.ScreenDimensions = new Vector2(1920, 1080);

            SetBackground("Menu", BackgroundType.Stretch);
            AudioManager.Instance.PlayBGM("MenuMusic");

            Transition.Instance.EndTransition();

            AddObject(new Start(), 820, 63);
            AddObject(new Control(), 720, 330);
            AddObject(new Credits(), 1010, 330);

            _mouse = new Mouse();
            AddObject(_mouse, 0, 0);
            GameInput.SetMousePosition(core.GraphicsDevice.Viewport.Bounds.Center.ToVector2());
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here

        }
    }
}
