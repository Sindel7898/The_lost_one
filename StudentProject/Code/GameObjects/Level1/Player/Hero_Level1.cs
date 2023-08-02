using System;
using System.Collections.Generic;
using System.Text;
using MonoGame;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects.Enemies;
using StudentProject.Code.GameObjects.Pickups;
using StudentProject.Code.GameObjects.Projectiles;
using StudentProject.Code.GameObjects.World_Objects;
using StudentProject.Code.Screens;

namespace StudentProject.Code.GameObjects.Player
{
    class Hero_Level1 : GameObject
    {
        //Sets the ints for speed score and lives and uses a boolean to activate gravity
        private int _speed = 6;
        private int _lives = 3;
        private int _score = 0;
        private bool _gravity = true;
        
        
        
        
        // Sets the players idel animation and also uses if statement to play a damage animation if the players lives equals 0
        public Hero_Level1()
        {
            SetSprite("Danni Kungfu Ideal Attack new",49, 58, 0.1f, new int[] { 3 });
            GetAnimatedSprite().SetPaused(false);
            if(_lives == 1)
            {
                SetSprite("Danni Kungfu Damaget", 49, 58, 0.08f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
            }
            

        }
        public override void Update(float deltaTime)
        {
            HandleInput();
            CheckCollisons();
            CheckForObstacles();
            CheckGravity();
            Fire();

           
        }
        //Checls to see the player is touching all main objects within the level
        private void CheckForObstacles()
        {
            if (IsAtScreenEdge())
                RevertPosition();
           if(IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>() || IsTouching<SmallBox>() || IsTouching<Large_Box>())
            {
                _gravity= false;
            }
           if(!IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>() || IsTouching<SmallBox>() || IsTouching<Large_Box>())
            {
                _gravity= true;
            }
            
        }
        //This checks to see if the player collides with certain objects and uses if statements to alter the above ints and remove those objects, also makes use a camera shake to give the player feedback when they take damage

        private void CheckCollisons()
        {

            if (_lives <= 0)
            {
                Transition.Instance.ToScreen<GameOverMenu>(TransitionType.Fade);
                GetScreen().RemoveObject(this);
            }

            GameObject other = GetOneIntersectingObject<Coin_Pickup>();
            if (other != null)
            {
                _score++;
                GetScreen().RemoveObject(other);

            }
            GameObject otherss = GetOneIntersectingObject<Ninja_Spear>();
            if (otherss != null)
            {
                _lives--;
                GetScreen().RemoveObject(otherss);
                Camera2D.Instance.Shake(4.0f, 0.25f);
            }
            GameObject othe = GetOneIntersectingObject<Demon_Fire_Blast>();
            if (othe != null)
            {
                _score--;
                _lives--;
                GetScreen().RemoveObject(othe);
                SetSprite("Danni Kungfu Damaget", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
                Camera2D.Instance.Shake(4.0f, 0.25f);

            }



            GameObject others = GetOneIntersectingObject<Fel_Fire_Blast>();
            if (others != null)
            {
                _score--;
                _lives--;
                GetScreen().RemoveObject(others);
                SetSprite("Danni Kungfu Damaget", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
                Camera2D.Instance.Shake(4.0f, 0.25f);
            }
            GameObject o = GetOneIntersectingObject<HealthPickUp>();
            if (o != null && _lives < 5)
            {
                _lives++;
                GetScreen().RemoveObject(o);

                if (_lives <= 0)
                {
                    GetScreen().RemoveObject(this);
                    

                }
            }
           

            GameObject ot = GetOneIntersectingObject<Door>();
            if (ot != null)
            {
                Transition.Instance.ToScreen<Level_2>(TransitionType.Fade);
                AudioManager.Instance.PlaySFX("Door", this, SFXOverlapRule.Overwrite);
                GetScreen().RemoveObject(this);
            }

        }
        //This checks to see if gravity is true, then it applies a speed of +10 to pull the player down to the platforms
        private void CheckGravity()
        {
            if (_gravity == true)
            {
                SetPosition(GetX(), GetY() + 10);
                if (IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>())

                    RevertPosition();
            }
        }
        //This uses if statements to determine what buttons and animations to play depending on how the user chooses to interact with the controls
        private void HandleInput()
        {   
            if (GameInput.IsKeyHeld("A"))
            {
                
                SetPosition(GetX() - _speed, GetY());
                SetSprite("Danni Kung Fu Run right to left new",47, 63, 0.1f, new int[] { 4 }, LoopType.Standard);
                GetAnimatedSprite().SetPaused(false);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();

            }
            if(GameInput.IsKeyReleased("A"))
            {
                SetSprite("Danni Kungfu Ideal Attack new", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
            }
         
            if (GameInput.IsKeyHeld("D"))
            {
                
                SetPosition(GetX() + _speed, GetY());
                SetSprite("Danni Kung Fu Run Left New",47, 63, 0.1f, new int[] { 4 }, LoopType.Standard);
                GetAnimatedSprite().SetPaused(false);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();

            }
            if (GameInput.IsKeyReleased("D"))
            {
                SetSprite("Danni Kungfu Ideal Attack new", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
            }

            if (GameInput.IsKeyHeld("W"))
            {
                SetPosition(GetX(), GetY() - _speed);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();
            }
            if (GameInput.IsKeyReleased("W"))
            {
                SetSprite("Danni Kungfu Ideal Attack new", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
            }
            if (GameInput.IsKeyHeld("S"))
            {
                SetPosition(GetX(), GetY() + _speed);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();
            }
            if (GameInput.IsKeyReleased("S"))
            {
                SetSprite("Danni Kungfu Ideal Attack new", 49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
            }
            if (GameInput.IsKeyPressed("Space"))
            {
                _gravity = false;
                SetPosition(GetX() + 25, GetY() - 95);
                SetSprite("Danni kung-fu jumping left to right-Sheet",59, 83, 0.1f, new int[] { 7 });
                GetAnimatedSprite().SetPaused(false);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();
            }
            if (GameInput.IsKeyReleased("Space"))
            {
                _gravity = true;
                
                 SetSprite("Danni Kungfu Ideal Attack new",49, 58, 0.1f, new int[] { 3 });
                GetAnimatedSprite().SetPaused(false);
                if (IsAtScreenEdge() || IsTouching<Wall>() || IsTouching<Wall_Vertical>() || IsTouching<Large_Box>() || IsTouching<SmallBox>() || IsTouching<Platform>() || IsTouching<Platform2>() || IsTouching<Platform3>())
                    RevertPosition();
            }

            if (IsAtScreenEdge())
                RevertPosition();
            
        }
        //Checks to see if the fire command is pressed
        private void Fire()
        {
            if (GameInput.IsKeyPressed("F"))
            {
                GetScreen().AddObject(new Throwing_Star(), (int)GetCenter().X, (int)GetCenter().Y);
            }
        }
        //Returns score and lives
        public void AddScore(int score)
        {
            _score += score;
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetLives()
        {
            return _lives;
        }
    }
}
