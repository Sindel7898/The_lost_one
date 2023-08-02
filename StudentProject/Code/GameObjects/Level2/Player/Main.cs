using MonoGameEngine.StandardCore;
using MonoGameEngine;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using StudentProject.Code.Screens;
using StudentProject.Code.GameObjects.Level2.BadGuys;

namespace StudentProject.Code.GameObjects
{

    class Main : GameObject
    {
        // Creating Variables
        public int _randomX = 0;
        public int _randomY = 0;
        private int _speed = 4;
        public float _time = 120.0f;
        public int _Level2lives = 3;
        private bool _rising;
        private int _currentFrame;

        public Main()
        {

            SetSprite("idlemain");





        }
        public override void Update(float deltaTime)
        {


            PlayerMovement();
            DoorCol();
            
            CollisionsWallTop();
            CollisionsWallButtom();
            CollisionWallDown();
            Playercollision();


        }

        

        // Player Movement which allows the character to move and change sprite when moving also plays the creaking sound randomally in this part of the code 
        private void PlayerMovement()
        {

          




            if (GameInput.IsKeyPressed("S"))
            {
                SetSprite("maindown", 19, 32, 0.05f, new int[] { 5 });
                int randomnumber = Core.GetRandomNumber(15);
                if (randomnumber == 0)
                {
                    AudioManager.Instance.PlaySFX("woodcreak", this, SFXOverlapRule.Overwrite);
                }
            

            }

            if (GameInput.IsKeyHeld("S"))
            {
                SetPosition(GetX(), GetY() + _speed);
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();



            }


            if (GameInput.IsKeyPressed("W"))
            {
                SetSprite("mainup", 19, 32, 0.05f, new int[] { 5 });
                int randomnumber = Core.GetRandomNumber(15);
                if (randomnumber == 0)
                {
                    AudioManager.Instance.PlaySFX("woodcreak", this, SFXOverlapRule.Overwrite);
                }
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();

            }
            if (GameInput.IsKeyHeld("W"))
            {
                SetPosition(GetX(), GetY() - _speed);
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();
            }

            if (GameInput.IsKeyPressed("D"))
            {
                SetSprite("mainright", 16, 35, 0.05f, new int[] { 5 });
                int randomnumber = Core.GetRandomNumber(15);
                if (randomnumber == 0)
                {
                    AudioManager.Instance.PlaySFX("woodcreak", this, SFXOverlapRule.Overwrite);
                }
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();
            }
            if (GameInput.IsKeyHeld("D"))
            {
                SetPosition(GetX() + _speed, GetY());
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();
            }

            if (GameInput.IsKeyPressed("A"))
            {
                SetSprite("mainleft", 16, 35, 0.05f, new int[] { 5 });
                int randomnumber = Core.GetRandomNumber(15);
                if (randomnumber == 0)
                {
                    AudioManager.Instance.PlaySFX("woodcreak", this, SFXOverlapRule.Overwrite);
                }
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();




            }
            if (GameInput.IsKeyHeld("A"))
            {
                SetPosition(GetX() - _speed, GetY());
                if (IsTouching<WallAcrossButtom>())
                    RevertPosition();
                if (IsTouching<WallDown>())
                    RevertPosition();
                if (IsTouching<WallAcrossTop>())
                    RevertPosition();
            }









        }

        // plays a random sound of a woman screaming
   
        // Colliions for Walls Start
        private void CollisionsWallTop()
        {
            if (IsTouching<WallAcrossTop>())
                RevertPosition();


        }

        private void CollisionsWallButtom()
        {
            if (IsTouching<WallAcrossButtom>())
                RevertPosition();
          



        }

        private void CollisionWallDown()
        {
            if (IsTouching<WallDown>())
                RevertPosition();

        }
        // Collisions for Wall End
        // Door Collision 
        private void DoorCol()
        {
            GameObject ot = GetOneIntersectingObject<DoorLevel2>();
            if (ot != null)
            {
                Transition.Instance.ToScreen<BossLevel>(TransitionType.Fade);
                AudioManager.Instance.PlaySFX("Door", this, SFXOverlapRule.Overwrite);
                GetScreen().RemoveObject(this);
            }


        }

        private void Playercollision()
        {


            if (_Level2lives <= 0)
            {
                Transition.Instance.ToScreen<GameOverMenu>(TransitionType.Fade);
                GetScreen().RemoveObject(this);
            }

            GameObject ot = GetOneIntersectingObject<Bad>();
            if (ot != null)
            {
                --_Level2lives;
                GetScreen().RemoveObject(ot);
                Shake();
            }

            GameObject ot1 = GetOneIntersectingObject<Bad3>();
            if (ot1 != null)
            {
                --_Level2lives;
                GetScreen().RemoveObject(ot1);
                Shake();
            }

            GameObject ot2 = GetOneIntersectingObject<Bad4>();
            if (ot2 != null)
            {

                --_Level2lives;
                GetScreen().RemoveObject(ot2);
                Shake();
            }

            GameObject ot3 = GetOneIntersectingObject<Bad5>();
            if (ot3 != null)
            {
                --_Level2lives;
                GetScreen().RemoveObject(ot3);
                Shake();

            }

            GameObject ot4 = GetOneIntersectingObject<BadTwo>();
            if (ot4 != null)
            {
                --_Level2lives;
                GetScreen().RemoveObject(ot4);
                Shake();

            }

        }


        public void Shake()
        {
            

            Camera2D.Instance.Shake(4.0f, 0.25f);
            _rising = true;
            _currentFrame = 0;
            GetSprite();
        }

        public int GetLevel2lives()
        {
            return _Level2lives;
        }


    }
}
