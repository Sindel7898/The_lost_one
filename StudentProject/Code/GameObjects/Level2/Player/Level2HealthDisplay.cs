using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MonoGameEngine.StandardCore;
using Microsoft.Xna.Framework;

namespace StudentProject.Code.GameObjects
{
    class Level2HealthDisplay :GameObject
    {
        private int _health;

        //sets sprite for the health display 
        public Level2HealthDisplay()
        {
            SetSprite("Player health");
            GetSprite().SetInWorldSpace(false);
        }
        public override void Update(float deltaTime)
        {

        }

        public override void Render(SpriteBatch spriteBatch)
        {
           for (int i = 0; i < _health; i++)
            {
                spriteBatch.Draw(GetSprite().GetTexture(), new Microsoft.Xna.Framework.Vector2(GetX() + (i * GetSprite().GetWidth()), GetY()), color:Microsoft.Xna.Framework.Color.White);
            }

        }
        public void SetHealth(int health)
        {
            _health = health;
        }

        
        
    }
}
