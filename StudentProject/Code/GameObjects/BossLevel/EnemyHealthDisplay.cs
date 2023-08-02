using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MonoGameEngine.StandardCore;
using Microsoft.Xna.Framework;

namespace StudentProject.Code.GameObjects
{
    class EnemyHealthDisplay : GameObject
    {
        private int _enemyheart;

        //set sprite for enemyhealth
        public EnemyHealthDisplay ()
        {
            SetSprite("Enemy health");
            GetSprite().SetInWorldSpace(false);
        }
        public override void Update(float deltaTime)
        {

        }


        public override void Render(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < _enemyheart; i++)
            {
                spriteBatch.Draw(GetSprite().GetTexture(), new Microsoft.Xna.Framework.Vector2(GetX() + (i * GetSprite().GetWidth()), GetY()), color: Microsoft.Xna.Framework.Color.White);
            }

        }
        public void SetEnemyHealth(int enemyhealth)
        {
            _enemyheart = enemyhealth;
        }
    }
}
