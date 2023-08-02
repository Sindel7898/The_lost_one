using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects.World_Objects
{   //Creates a game object and sets sprite and animation for the sewage pipe
    class Sewage_Pipe : GameObject
    {
        public Sewage_Pipe()
        {
            SetSprite("Sewage Pipe2", 128, 0.1f, new int[] { 6 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
        }
        public override void Update(float deltaTime)
        {
            
        }
    }
}
