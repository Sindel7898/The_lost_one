using MonoGameEngine.StandardCore;
using MonoGameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using StudentProject.Code.GameObjects;

namespace StudentProject.Code.Screens
{
    public class ControlScreen : Screen
    {
        Mouse _mouse;

        public override void Start(Core core)
        {
            base.Start(core);

            Transition.Instance.EndTransition();
            SetBackground("ControlScreen");

            AddObject(new Back(), 10, 10);
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
