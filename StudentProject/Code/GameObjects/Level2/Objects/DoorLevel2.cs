using MonoGameEngine;
using MonoGameEngine.StandardCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject.Code.GameObjects
{
    class DoorLevel2 : GameObject
    {
        public int _randomX;
        public int _randomY;
        public DoorLevel2()
        {
            SetSprite("doorlevel2");
        }
        public override void Update(float deltaTime)
        {
          
        }
        // My Random Spawning code that chooses and random option of X and Y Coords
        public int RandommovementX()
        {
            int randomnumber = Core.GetRandomNumber(3);
            switch (randomnumber)
            {
                case 0:
                    _randomX = 336;
                    _randomY = 1525;
                    break;
               case 1:
                    _randomX = 1456;
                    _randomY = 1216;
                    break;
                case 2:
                    _randomX = 1292;
                    _randomY = 300;
                    break;
            

            }
            return _randomX;
           


        }


        public int RandommovementY()
        {
            
            return _randomY;



        }
    }
}
