using System.Numerics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;
using StudentProject.Code.GameObjects.Enemies;
using StudentProject.Code.GameObjects.Pickups;
using StudentProject.Code.GameObjects.Player;
using StudentProject.Code.GameObjects.World_Objects;

namespace StudentProject.Code.Screens
{
    //Sets the variables for health,player and score
    public class Level_1 : Screen
    {
        HealthDisplayLevel1 _healthDisplay;
        Hero_Level1 _player;
        Text _score;
        public override void Start(Core core)
        {
            //Sets the background, filling the background with magenta then laying over the sprite image for background art at a 1920,1080 resolution
            base.Start(core);
            Settings.BackgroundFill = Color.DarkMagenta;
            Settings.ScreenDimensions = new Microsoft.Xna.Framework.Vector2(1920, 1080);
            SetBackground("Background art", BackgroundType.Stretch);
           

            //Spawn in the Hero Character
            _player = new Hero_Level1();
            AddObject(_player, 100, 650);
            
            

            //Spawn in Health Display
            _healthDisplay = new HealthDisplayLevel1();
            AddObject(_healthDisplay, 20, 50);

            //Spawn in Score
            _score = new Text("Score: 0", Color.White);
            AddText(_score, 30, 20);


            //Horizontal Platform 1 Walls
            AddObject(new Wall(), 0, 735);
            AddObject(new Wall(), 25, 735);
            AddObject(new Wall(), 50, 735);
            AddObject(new Wall(), 75, 735);
            AddObject(new Wall(), 100, 735);
            AddObject(new Wall(), 125, 735);
            AddObject(new Wall(), 150, 735);
            AddObject(new Wall(), 175, 735);
            AddObject(new Wall(), 200, 735);
            AddObject(new Wall(), 225, 735);
            AddObject(new Wall(), 245, 735);

            //Vertical Platform 1 Walls
            AddObject(new Wall_Vertical(), 273, 735);
            AddObject(new Wall_Vertical(), 273, 760);
            AddObject(new Wall_Vertical(), 273, 785);
            AddObject(new Wall_Vertical(), 273, 810);
            AddObject(new Wall_Vertical(), 273, 835);
            AddObject(new Wall_Vertical(), 273, 860);
            AddObject(new Wall_Vertical(), 273, 885);
            AddObject(new Wall_Vertical(), 273, 910);
            AddObject(new Wall_Vertical(), 273, 935);
            AddObject(new Wall_Vertical(), 273, 950);

            //Horizontal Water Walls
            AddObject(new Wall(), 270, 980);
            AddObject(new Wall(), 295, 980);
            AddObject(new Wall(), 320, 980);
            AddObject(new Wall(), 345, 980);
            AddObject(new Wall(), 370, 980);
            AddObject(new Wall(), 390, 980);
            AddObject(new Wall(), 415, 980);
            AddObject(new Wall(), 440, 980);
            AddObject(new Wall(), 465, 980);

            //Game Objects Platform 1
            AddObject(new Large_Box(), 215, 675);
            AddObject(new SmallBox(), 185, 705);
            AddObject(new Torches(), 50, 650);
            AddObject(new Sewage_Pipe(), 350, 651);
            AddObject(new Coin_Pickup(), 100, 702);

            //Horizontal Wall Platform 2
            AddObject(new Wall(),495, 560);
            AddObject(new Wall(),520, 560);
            AddObject(new Wall(),545, 560);
            AddObject(new Wall(),570, 560);
            AddObject(new Wall(),595, 560);
            AddObject(new Wall(),620, 560);
            AddObject(new Wall(),645, 560);
            AddObject(new Wall(),670, 560);
            AddObject(new Wall(),695, 560);
            AddObject(new Wall(),715, 560);

            //Vertical Wall Left Platform 2
            AddObject(new Wall_Vertical(), 500, 565);
            AddObject(new Wall_Vertical(), 500, 590);
            AddObject(new Wall_Vertical(), 500, 615);
            AddObject(new Wall_Vertical(), 500, 640);
            AddObject(new Wall_Vertical(), 500, 665);
            AddObject(new Wall_Vertical(), 500, 690);
            AddObject(new Wall_Vertical(), 500, 715);
            AddObject(new Wall_Vertical(), 500, 740);
            AddObject(new Wall_Vertical(), 500, 765);
            AddObject(new Wall_Vertical(), 500, 790);
            AddObject(new Wall_Vertical(), 500, 815);
            AddObject(new Wall_Vertical(), 500, 840);
            AddObject(new Wall_Vertical(), 500, 865);
            AddObject(new Wall_Vertical(), 500, 890);
            AddObject(new Wall_Vertical(), 500, 915);
            AddObject(new Wall_Vertical(), 500, 940);
            AddObject(new Wall_Vertical(), 500, 950);

            //Vertical Wall Right Platform 2
            AddObject(new Wall_Vertical(), 743, 565);
            AddObject(new Wall_Vertical(), 743, 590);
            AddObject(new Wall_Vertical(), 743, 615);
            AddObject(new Wall_Vertical(), 743, 640);
            AddObject(new Wall_Vertical(), 743, 665);
            AddObject(new Wall_Vertical(), 743, 690);
            AddObject(new Wall_Vertical(), 743, 715);
            AddObject(new Wall_Vertical(), 743, 740);
            AddObject(new Wall_Vertical(), 743, 765);
            AddObject(new Wall_Vertical(), 743, 790);
            AddObject(new Wall_Vertical(), 743, 815);
            AddObject(new Wall_Vertical(), 743, 840);
            AddObject(new Wall_Vertical(), 743, 865);
            AddObject(new Wall_Vertical(), 743, 890);
            AddObject(new Wall_Vertical(), 743, 915);
            AddObject(new Wall_Vertical(), 743, 940);
            AddObject(new Wall_Vertical(), 743, 950);
            AddObject(new Wall_Vertical(), 743, 975);
            AddObject(new Wall_Vertical(), 743, 1000);


            //Game Objects Vertical Platform 2
            AddObject(new Platform(),428, 615); //Left Platform
            AddObject(new Platform2(),748, 690); //Right Platform



            //Game Objects Vertical Wall Platform 3 Left
            AddObject(new Wall_Vertical(), 987, 835);
            AddObject(new Wall_Vertical(), 987, 810);
            AddObject(new Wall_Vertical(), 987, 785);
            AddObject(new Wall_Vertical(), 987, 760);
            AddObject(new Wall_Vertical(), 987, 735);
            AddObject(new Wall_Vertical(), 987, 710);
            AddObject(new Wall_Vertical(), 987, 685);
            AddObject(new Wall_Vertical(), 987, 660);
            AddObject(new Wall_Vertical(), 987, 635);
            AddObject(new Wall_Vertical(), 987, 610);
            AddObject(new Wall_Vertical(), 987, 585);
            AddObject(new Wall_Vertical(), 987, 560);
            AddObject(new Wall_Vertical(), 987, 535);
            AddObject(new Wall_Vertical(), 987, 517);

            //Game Object Horizontal Wall Platform 3 Top
            AddObject(new Wall(), 988, 517);
            AddObject(new Wall(), 1013, 517);
            AddObject(new Wall(), 1038, 517);
            AddObject(new Wall(), 1063, 517);
            AddObject(new Wall(), 1088, 517);
            AddObject(new Wall(), 1113, 517);
            AddObject(new Wall(), 1138, 517);
            AddObject(new Wall(), 1163, 517);
            AddObject(new Wall(), 1184, 517);

            //Game Object Horiztonal Wall Platform 3 Bottom
            AddObject(new Wall(), 988, 859);
            AddObject(new Wall(), 1013, 859);
            AddObject(new Wall(), 1038, 859);
            AddObject(new Wall(), 1063, 859);
            AddObject(new Wall(), 1088, 859);
            AddObject(new Wall(), 1113, 859);
            AddObject(new Wall(), 1138, 859);
            AddObject(new Wall(), 1163, 859);
            AddObject(new Wall(), 1184, 859);

            //Game Object Vertical Wall Platform 3 Right
            AddObject(new Wall_Vertical(), 1207, 835);
            AddObject(new Wall_Vertical(), 1207, 810);
            AddObject(new Wall_Vertical(), 1207, 785);
            AddObject(new Wall_Vertical(), 1207, 760);
            AddObject(new Wall_Vertical(), 1207, 735);
            AddObject(new Wall_Vertical(), 1207, 710);
            AddObject(new Wall_Vertical(), 1207, 685);
            AddObject(new Wall_Vertical(), 1207, 660);
            AddObject(new Wall_Vertical(), 1207, 635);
            AddObject(new Wall_Vertical(), 1207, 610);
            AddObject(new Wall_Vertical(), 1207, 585);
            AddObject(new Wall_Vertical(), 1207, 560);
            AddObject(new Wall_Vertical(), 1207, 535);
            AddObject(new Wall_Vertical(), 1207, 517);

            //Game Object Vertical Platform 3 Left
            AddObject(new Platform(), 927, 824);
            AddObject(new Platform(), 927, 570);

            //Game Object Vertical Platform 3 Right
            AddObject(new Platform3(), 1215, 835);
            AddObject(new Platform3(), 1215, 635);
            AddObject(new Coin_Pickup(), 1315, 585);

            //Game Object Platform 3
            AddObject(new Demon_Hydra(0), 1130, 422);
            AddObject(new Steel_Chain(), 800, 500);
            AddObject(new Steel_Chain(), 1400, 500);
            AddObject(new Coin_Pickup(), 980, 482);

            //Underground Horizontal Platform
            AddObject(new Wall(),725, 1020);
            AddObject(new Wall(),750, 1020);
            AddObject(new Wall(),775, 1020);
            AddObject(new Wall(),800, 1020);
            AddObject(new Wall(),825, 1020);
            AddObject(new Wall(),850, 1020);
            AddObject(new Wall(),875, 1020);
            AddObject(new Wall(),900, 1020);
            AddObject(new Wall(),925, 1020);
            AddObject(new Wall(),950, 1020);
            AddObject(new Wall(),975, 1020);
            AddObject(new Wall(),1000, 1020);
            AddObject(new Wall(),1025, 1020);
            AddObject(new Wall(),1050, 1020);
            AddObject(new Wall(),1075, 1020);
            AddObject(new Wall(),1100, 1020);
            AddObject(new Wall(),1125, 1020);
            AddObject(new Wall(),1150, 1020);
            AddObject(new Wall(),1175, 1020);
            AddObject(new Wall(),1200, 1020);
            AddObject(new Wall(),1225, 1020);
            AddObject(new Wall(),1250, 1020);
            AddObject(new Wall(),1275, 1020);
            AddObject(new Wall(),1300, 1020);
            AddObject(new Wall(),1325, 1020);
            AddObject(new Wall(),1345, 1020);

            //Game Object Underground Platform
            AddObject(new Large_Box(), 1293, 955);
            
            AddObject(new Large_Box(), 746, 955);
            AddObject(new Large_Box(), 746, 891);
            AddObject(new Coin_Pickup(), 1050, 985);
            AddObject(new Torches(), 885, 900);
            AddObject(new Torches(), 1185, 900);
            AddObject(new Ninja_Spear(), 1092, 925);

            //Game Object Veritcal Wall Left Platform 4
            AddObject(new Wall_Vertical(), 1356, 1000);
            AddObject(new Wall_Vertical(), 1356, 975);
            AddObject(new Wall_Vertical(), 1356, 950);
            AddObject(new Wall_Vertical(), 1356, 925);
            AddObject(new Wall_Vertical(), 1356, 900);
            AddObject(new Wall_Vertical(), 1356, 875);
            AddObject(new Wall_Vertical(), 1356, 850);
            AddObject(new Wall_Vertical(), 1356, 825);
            AddObject(new Wall_Vertical(), 1356, 800);
            AddObject(new Wall_Vertical(), 1356, 775);
            AddObject(new Wall_Vertical(), 1356, 750);
            AddObject(new Wall_Vertical(), 1356, 740);

            //Game Object Vertical Wall Right Platform 4 Part 1
            AddObject(new Wall_Vertical(), 1511, 737);
            AddObject(new Wall_Vertical(), 1511, 762);
            AddObject(new Wall_Vertical(), 1511, 787);

            //Game Object Vertical Wall Right Platform 4 Part 2
            AddObject(new Wall_Vertical(), 1709, 814);
            AddObject(new Wall_Vertical(), 1709, 839);
            AddObject(new Wall_Vertical(), 1709, 864);
            AddObject(new Wall_Vertical(), 1709, 889);
            AddObject(new Wall_Vertical(), 1709, 914);
            AddObject(new Wall_Vertical(), 1709, 939);
            AddObject(new Wall_Vertical(), 1709, 955);

            //Game Object Horiztonal Wall Platform 4 Part 1
            AddObject(new Wall(), 1357, 736);
            AddObject(new Wall(), 1372, 736);
            AddObject(new Wall(), 1397, 736);
            AddObject(new Wall(), 1422, 736);
            AddObject(new Wall(), 1447, 736);
            AddObject(new Wall(), 1472, 736);
            AddObject(new Wall(), 1487, 736);

            //Game Object Horizontal Platform 4 Part 1
            AddObject(new Fel_Hydra(), 1427, 645);

            //Game Object Horiztonal Wall Platform 4 Part 2
            AddObject(new Wall(), 1510, 812);
            AddObject(new Wall(), 1535, 812);
            AddObject(new Wall(), 1560, 812);
            AddObject(new Wall(), 1585, 812);
            AddObject(new Wall(), 1610, 812);
            AddObject(new Wall(), 1635, 812);
            AddObject(new Wall(), 1660, 812);
            AddObject(new Wall(), 1685, 812);

            //Game Object Horizontal Wall Platform 4 Part 3
            AddObject(new Wall(), 1710, 982);
            AddObject(new Wall(), 1735, 982);
            AddObject(new Wall(), 1760, 982);
            AddObject(new Wall(), 1785, 982);
            AddObject(new Wall(), 1810, 982);
            AddObject(new Wall(), 1835, 982);
            AddObject(new Wall(), 1860, 982);
            AddObject(new Wall(), 1880, 982);

            //Game Object Horizontal Platform 4 Part
            AddObject(new Door(), 1810, 855);
            AddObject(new Torches(), 1750, 875);
            AddObject(new Coin_Pickup(), 1767, 950);




            //Transistion code to end transistion
            Transition.Instance.EndTransition(TransitionType.Fade, 0.25f);
            




        }
        //Updates players health and score
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            _healthDisplay.SetHealth(_player.GetLives());
            _score.SetMessage("Score: " + _player.GetScore());
            SpawnPickUps();
        }
        //Randomly spawns hearts
        private void SpawnPickUps()
        {
            if (Core.GetRandomNumber(500) <= 0)
            {
                AddObject(new HealthPickUp(), Core.GetRandomNumber((int)Settings.ScreenDimensions.X - 84), 0);
                
            }

        }


    }
}
