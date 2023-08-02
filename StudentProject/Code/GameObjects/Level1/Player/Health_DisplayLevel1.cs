using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame;
using MonoGameEngine.StandardCore;

namespace StudentProject.Code.GameObjects.Player
{
    class HealthDisplayLevel1 : GameObject
    {
        //Set int as health and displays the players health
        private int _health;
        public HealthDisplayLevel1()
        {
            SetSprite("Player health");
            GetSprite().SetInWorldSpace(false);
        }
        public override void Update(float deltaTime)
        {

        }
        //Uses an array to assign and update the health display bar to accuratly display the health
        public override void Render(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < _health; i++)
            {
                spriteBatch.Draw(GetSprite().GetTexture(), new Vector2(GetX() + i * GetSprite().GetWidth(), GetY()), Color.White);
            }
        }
        //Sets health
        public void SetHealth(int health)
        {
            _health = health;
        }
    }
}
