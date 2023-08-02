using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;
using MonoGameEngine;
namespace StudentProject.Code.GameObjects

{
    class Bullet : GameObject
    {
        private int _speed = 4;
        public int _Enemylives = 3;

        public Bullet()
        {

            //sets the sprite for the bullet 
            SetSprite("Bullet");
            GetSprite().SetOrigin(0.5f, 0.5f);
            GetSprite().SetLayerDepth(4);
        }

        //constanly moves the direction of the bullet up towords the Y axis and if it goes off screen its removed
        public override void Update(float deltaTime)
        {
            SetPosition(GetX(), GetY() - _speed);

            if (IsOffscreen())
            {
                GetScreen().RemoveObject(this);
            }
          
        }

        // gets the enemyslives
        public int GetEnemylives()
        {
            return _Enemylives;
        }
    }
}