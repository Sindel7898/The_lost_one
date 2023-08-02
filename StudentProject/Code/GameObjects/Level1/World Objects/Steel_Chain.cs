using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{
    //Creates a game object and sets sprite and animation for the steel chain
    class Steel_Chain : GameObject
    {
        public Steel_Chain()
        {
            SetSprite("Steel_Chain", 96, 0.1f, new int[] { 7 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
        }
        public override void Update(float deltaTime)
        {
            
        }
    }
}
