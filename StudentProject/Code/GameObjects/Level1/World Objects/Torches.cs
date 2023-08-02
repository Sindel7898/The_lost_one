using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects
{
    //Creates a game object and sets sprite and animation for the game object torch
    class Torches : GameObject
    {
        public Torches()
        {
            SetSprite("Torch2", 64, 0.1f, new int[] { 3 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
        }
        public override void Update(float deltaTime)
        {
            
        }
    }
}
