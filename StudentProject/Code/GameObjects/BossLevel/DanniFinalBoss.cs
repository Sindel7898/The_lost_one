using System;
using System.Collections.Generic;
using System.Text;
using MonoGameEngine.StandardCore;
using MonoGameEngine;
using StudentProject.Code.Screens;


namespace StudentProject.Code.GameObjects
{
    class DanniFinalBoss:GameObject
    {
        //declaiers speed, lives,score,bosshealth
        private int _speed = 4;
        public int _lives = 3;
        private int _score = 0;
        public int BossHealth = 400;
        private bool _rising;
        private int _currentFrame;

        public DanniFinalBoss()
        {
            //sets the sprite of player 
            SetSprite("Danni Final  Boss Idle",108,138,0.1f, new int[] { 9 });
        }
        public override void Update(float deltaTime)
        {
            HandleInput();
          
            CheckCollisionsBullet();
            CheckCollisionsHeart();
            CheckCollisionsDoor();
            CheckForObstacle();
        }


        private void HandleInput()
        {
            /* checks if the player presses A and and if its pressed
            dannifinnalboss is moved - on the X axis at a speed of 4*/
            if (GameInput.IsKeyHeld("a"))
            {
                SetPosition(GetX() - _speed, GetY());
               
                CheckForObstacle();
            }
            if(GameInput.IsKeyPressed("A"))
            {
                SetSprite("Danni Final  Boss Idle", 108, 138, 0.1f, new int[] { 9 });
            }
            

            /* checks if the player presses D and and if its pressed
            dannifinnalboss is moved + on the X axis at a speed of 4*/
            if (GameInput.IsKeyHeld("d"))
            {
                SetPosition(GetX() + _speed, GetY());
               
                CheckForObstacle();
            }
            if(GameInput.IsKeyPressed("D"))
            {
                SetSprite("Danni Final  Boss Idle", 108, 138, 0.1f, new int[] { 9 });
                GetSprite().FlipHorizontally(true);
            }

            /*if the mouse button is pressed on the left a zap sound effect is played 
            and the bullet object is added to the screen and moves up */
            if (GameInput.IsMouseButtonPressed(MouseButton.Left))
            {

                GetScreen().AddObject(new Bullet(), (int)GetCenter().X, (int)GetPosition().Y);
                AudioManager.Instance.PlaySFX("Zap", this, SFXOverlapRule.Overwrite);
            }

            /* if player moves to the edge of the screen thier 
            position is reverted to they last position they where in*/
            if (IsAtScreenEdge())
                RevertPosition();
        }

        /* checks if danni finalboss interacts with the endgame door 
        if it does the screen transitions to the congratualtions menu
        and the player object is removed form the screen*/
        private void CheckCollisionsDoor()
        {
            GameObject obj = GetOneIntersectingObject<EndGameDoor>();
            
            if (obj != null)
            {
                Transition.Instance.ToScreen<CongratulationsMenu>(TransitionType.Fade, Microsoft.Xna.Framework.Color.Black);
                GetScreen().RemoveObject(this);
            }
        }

        /*  checks if the boss bullet interacts with the player lives is minuesed by 1 
        and the object is removed from the screen */
        public void CheckCollisionsBullet()
        {
            GameObject obj = GetOneIntersectingObject<BossBullet>();
            if (obj != null)
            {
                _lives--;
                if (obj != null)
                {
                    GetScreen().RemoveObject(obj);
                }
                Shake();

                /* if lives is less than or equal to 0 the boss laugh audio is played and the player is removed from the screen 
                the screen then transitions to the game over menu */
                if (_lives <= 0)
                {
                    GetScreen().RemoveObject(this);
                    AudioManager.Instance.PlaySFX("BossLaugh", this, SFXOverlapRule.Overwrite);
                    Transition.Instance.ToScreen<GameOverMenu>(TransitionType.Fade);
                }
            }
        }


        /* shakes the screen */
        public void Shake()
        {
            GetScreen().AddObject(new SpellBook(), (int)GetCenter().X, (int)GetCenter().Y);
            Camera2D.Instance.Shake(4.0f, 0.25f);
            _rising = true;
            _currentFrame = 0;
            GetSprite();
        }


        /*checks if the player interacts with the heart and if it does 1 is added to lives and the heart is removed from the screen */
        private void CheckCollisionsHeart()
        {
            GameObject obj = GetOneIntersectingObject<Bonus>();
            if (obj != null)
            {
                _lives++;
                GetScreen().RemoveObject(obj);

            }
        }

    

        /* adds score */
        public void AddScore(int points)
        {
            _score += points;
        }

        /* get the integer that is stored on score */
        public int GetScore()
        {
            return _score;
        }

        /*gets the value stored in lives  */

        public int Getlives()
        {
            return _lives;
        }

        /*checks if dannifinalboss touches the grass and if it does the gets reverted to the last position  */
        private void CheckForObstacle()
        {
            if (IsAtScreenEdge() || IsTouching<Grass>())
                RevertPosition();
        }

    }
}
