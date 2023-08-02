using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.Player;

namespace StudentProject.Code.GameObjects.Pickups
{
    class Coin_Pickup : GameObject
    {
        //Sets the sprite for the animation of the coin
        public Coin_Pickup()
        {
            SetSprite("Coin", 32, 0.1f, new int[] { 5 }, LoopType.Standard);
            GetAnimatedSprite().SetPaused(false);
        }
        public override void Update(float deltaTime)
        {
            CheckCollisons();
        }
        //Checks if the collison for the coin has happened
        private void CheckCollisons()
        {
            GameObject other = GetOneIntersectingObject<Coin_Pickup>();
            if (other != null)
            {
                
                GetScreen().RemoveObject(other);

            }
        }
    }
}
