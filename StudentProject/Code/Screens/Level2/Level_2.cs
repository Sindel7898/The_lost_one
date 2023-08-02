using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;
using StudentProject.Code.GameObjects.Level2.BadGuys;

namespace StudentProject.Code.Screens
{
    public class Level_2 : Screen
    {

    
        Main _player;
        Bad _bad;
        BadTwo _bad2;
        Bad3 _Bad3;
        Bad4 _bad4;
        Bad5 _bad5;
        DoorLevel2 _Door;
        Level2HealthDisplay _Level2healthDisplay;
        public override void Start(Core core)
        {
            base.Start(core);
            // TODO: Add your Screen starting code below here
 
            // Player Spawned In
            _player = new Main();
            AddObject(_player, 144, 144);
            // Door Being Spawned in 
            _Door = new DoorLevel2();
            AddObject(_Door, _Door.RandommovementX(), _Door.RandommovementY());

            // Spawning In Each Bad Guy
            _bad = new Bad();
            AddObject(_bad, 144, 400);
            _bad2 = new BadTwo();
            AddObject(_bad2, 80, 725);
            _Bad3 = new Bad3();
            AddObject(_Bad3, 150, 1400);
            _bad4 = new Bad4();
            AddObject(_bad4, 700, 1250);
            _bad5 = new Bad5();
            AddObject(_bad5, 950, 1600);

            _Level2healthDisplay = new Level2HealthDisplay();
            AddObject(_Level2healthDisplay, 20, 50);


            // Camera/Audio/BGM/Background Code and Settings
            SetBackground("background");
            Settings.BackgroundFill = Color.DarkOliveGreen;
            Settings.ScreenDimensions = new Vector2(1920, 2000);
            Camera2D.Instance.Follow(_player);
    
            AudioManager.Instance.PlayBGM("theme") ;


            Transition.Instance.EndTransition(TransitionType.Fade, 0.25f);

            Walls();
            
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here


            _Level2healthDisplay.SetHealth(_player.GetLevel2lives());

        }


        private void Walls()
        {
            // Wall Spawning - Buttom


            AddObject(new WallAcrossButtom(), 16, 304);
            AddObject(new WallAcrossButtom(), 64, 304);
            AddObject(new WallAcrossButtom(), 240, 304);
            AddObject(new WallAcrossButtom(), 240, 464);
            AddObject(new WallAcrossButtom(), 286, 464);
            AddObject(new WallAcrossButtom(), 32, 592);
            AddObject(new WallAcrossButtom(), 64, 592);
            AddObject(new WallAcrossButtom(), 16, 944);
            AddObject(new WallAcrossButtom(), 32, 944);
            AddObject(new WallAcrossButtom(), 2, 1216);
            AddObject(new WallAcrossButtom(), 64, 1216);
            AddObject(new WallAcrossButtom(), 130, 1456);
            AddObject(new WallAcrossButtom(), 208, 1456);
            AddObject(new WallAcrossButtom(), 272, 1456);
            AddObject(new WallAcrossButtom(), 304, 1456);
            AddObject(new WallAcrossButtom(), 336, 1456);
            AddObject(new WallAcrossButtom(), 240, 1312);
            AddObject(new WallAcrossButtom(), 418, 96);
            AddObject(new WallAcrossButtom(), 370, 96);
            AddObject(new WallAcrossButtom(), 512, 720);
            AddObject(new WallAcrossButtom(), 480, 720);
            AddObject(new WallAcrossButtom(), 432, 720);
            AddObject(new WallAcrossButtom(), 352, 896);
            AddObject(new WallAcrossButtom(), 304, 896);
            AddObject(new WallAcrossButtom(), 352, 896);
            AddObject(new WallAcrossButtom(), 254, 720);
            AddObject(new WallAcrossButtom(), 254, 896);
            AddObject(new WallAcrossButtom(), 226, 1600);
            AddObject(new WallAcrossButtom(), 272, 1600);
            AddObject(new WallAcrossButtom(), 320, 1600);
            AddObject(new WallAcrossButtom(), 112, 1856);
            AddObject(new WallAcrossButtom(), 160, 1856);
            AddObject(new WallAcrossButtom(), 208, 1856);
            AddObject(new WallAcrossButtom(), 256, 1856);
            AddObject(new WallAcrossButtom(), 304, 1856);
            AddObject(new WallAcrossButtom(), 352, 1856);
            AddObject(new WallAcrossButtom(), 400, 1856);
            AddObject(new WallAcrossButtom(), 446, 1856);
            AddObject(new WallAcrossButtom(), 512, 1456);
            AddObject(new WallAcrossButtom(), 528, 1456);
            AddObject(new WallAcrossButtom(), 594, 1712);
            AddObject(new WallAcrossButtom(), 640, 1712);
            AddObject(new WallAcrossButtom(), 688, 1712);
            AddObject(new WallAcrossButtom(), 736, 1712);
            AddObject(new WallAcrossButtom(), 768, 1712);
            AddObject(new WallAcrossButtom(), 786, 1488);
            AddObject(new WallAcrossButtom(), 818, 1488);
            AddObject(new WallAcrossButtom(), 896, 1312);
            AddObject(new WallAcrossButtom(), 944, 1312);
            AddObject(new WallAcrossButtom(), 992, 1312);
            AddObject(new WallAcrossButtom(), 1024, 1312);
            AddObject(new WallAcrossButtom(), 994, 1536);
            AddObject(new WallAcrossButtom(), 1026, 1536);
            AddObject(new WallAcrossButtom(), 802, 1872);
            AddObject(new WallAcrossButtom(), 848, 1872);
            AddObject(new WallAcrossButtom(), 892, 1872);
            AddObject(new WallAcrossButtom(), 928, 1872);
            AddObject(new WallAcrossButtom(), 1008, 1712);
            AddObject(new WallAcrossButtom(), 1056, 1712);
            AddObject(new WallAcrossButtom(), 1104, 1712);
            AddObject(new WallAcrossButtom(), 1120, 1712);
            AddObject(new WallAcrossButtom(), 912, 992);
            AddObject(new WallAcrossButtom(), 960, 992);
            AddObject(new WallAcrossButtom(), 1008, 992);
            AddObject(new WallAcrossButtom(), 1056, 992);
            AddObject(new WallAcrossButtom(), 1104, 992);
            AddObject(new WallAcrossButtom(), 1152, 992);
            AddObject(new WallAcrossButtom(), 1200, 992);
            AddObject(new WallAcrossButtom(), 1248, 992);
            AddObject(new WallAcrossButtom(), 1296, 992);
            AddObject(new WallAcrossButtom(), 1344, 992);
            AddObject(new WallAcrossButtom(), 1282, 1264);
            AddObject(new WallAcrossButtom(), 1328, 1264);
            AddObject(new WallAcrossButtom(), 1376, 1264);
            AddObject(new WallAcrossButtom(), 1424, 1264);
            AddObject(new WallAcrossButtom(), 1454, 1264);
            AddObject(new WallAcrossButtom(), 800, 528);
            AddObject(new WallAcrossButtom(), 848, 528);
            AddObject(new WallAcrossButtom(), 896, 528);
            AddObject(new WallAcrossButtom(), 944, 528);
            AddObject(new WallAcrossButtom(), 960, 528);
            AddObject(new WallAcrossButtom(), 928, 784);
            AddObject(new WallAcrossButtom(), 976, 784);
            AddObject(new WallAcrossButtom(), 1024, 784);
            AddObject(new WallAcrossButtom(), 1056, 784);
            AddObject(new WallAcrossButtom(), 1136, 720);
            AddObject(new WallAcrossButtom(), 1184, 720);
            AddObject(new WallAcrossButtom(), 1136, 528);
            AddObject(new WallAcrossButtom(), 1184, 528);
            AddObject(new WallAcrossButtom(), 1232, 528);
            AddObject(new WallAcrossButtom(), 1280, 528);
            AddObject(new WallAcrossButtom(), 1296, 528);
            AddObject(new WallAcrossButtom(), 738, 176);
            AddObject(new WallAcrossButtom(), 784, 176);
            AddObject(new WallAcrossButtom(), 832, 176);
            AddObject(new WallAcrossButtom(), 848, 176);
            AddObject(new WallAcrossButtom(), 594, 896);
            AddObject(new WallAcrossButtom(), 624, 896);
            AddObject(new WallAcrossButtom(), 690, 992);
            AddObject(new WallAcrossButtom(), 736, 992);

            AddObject(new WallAcrossButtom(), 576, 1184);
            AddObject(new WallAcrossButtom(), 544, 1184);
            AddObject(new WallAcrossButtom(), 512, 1184);
            AddObject(new WallAcrossButtom(), 480, 1184);
            AddObject(new WallAcrossButtom(), 448, 1184);
            AddObject(new WallAcrossButtom(), 416, 1184);


            // Wall Spawning - Buttom (END)

            // Wall Spawning - Down
            AddObject(new WallDown(), 1248, 688);
            AddObject(new WallDown(), 1248, 656);
            AddObject(new WallDown(), 1248, 624);
            AddObject(new WallDown(), 1248, 608);
            AddObject(new WallDown(), 2, -16);
            AddObject(new WallDown(), 2, 32);
            AddObject(new WallDown(), 2, 64);
            AddObject(new WallDown(), 2, 96);
            AddObject(new WallDown(), 2, 128);
            AddObject(new WallDown(), 2, 160);
            AddObject(new WallDown(), 2, 192);
            AddObject(new WallDown(), 2, 224);
            AddObject(new WallDown(), 2, 256);
            AddObject(new WallDown(), 2, 272);
            AddObject(new WallDown(), 304, -16);
            AddObject(new WallDown(), 304, 32);
            AddObject(new WallDown(), 304, 64);
            AddObject(new WallDown(), 304, 96);
            AddObject(new WallDown(), 304, 128);
            AddObject(new WallDown(), 304, 160);
            AddObject(new WallDown(), 304, 192);
            AddObject(new WallDown(), 304, 224);
            AddObject(new WallDown(), 304, 256);
            AddObject(new WallDown(), 304, 272);
            AddObject(new WallDown(), 240, 320);
            AddObject(new WallDown(), 352, 352);
            AddObject(new WallDown(), 352, 384);
            AddObject(new WallDown(), 352, 416);
            AddObject(new WallDown(), 130, 320);
            AddObject(new WallDown(), 130, 320);
            AddObject(new WallDown(), 130, 320);
            AddObject(new WallDown(), 130, 352);
            AddObject(new WallDown(), 130, 384);
            AddObject(new WallDown(), 130, 416);
            AddObject(new WallDown(), 130, 448);
            AddObject(new WallDown(), 18, 464);
            AddObject(new WallDown(), 18, 512);
            AddObject(new WallDown(), 18, 560);
            AddObject(new WallDown(), 130, 592);
            AddObject(new WallDown(), 130, 640);
            AddObject(new WallDown(), 130, 672);
            AddObject(new WallDown(), 2, 688);
            AddObject(new WallDown(), 2, 720);
            AddObject(new WallDown(), 2, 752);
            AddObject(new WallDown(), 2, 784);
            AddObject(new WallDown(), 2, 816);
            AddObject(new WallDown(), 2, 848);
            AddObject(new WallDown(), 2, 880);
            AddObject(new WallDown(), 2, 912);
            AddObject(new WallDown(), 106, 816);
            AddObject(new WallDown(), 120, 816);
            AddObject(new WallDown(), 106, 848);
            AddObject(new WallDown(), 106, 880);
            AddObject(new WallDown(), 106, 912);
            AddObject(new WallDown(), 130, 880);
            AddObject(new WallDown(), 130, 846);
            AddObject(new WallDown(), 130, 912);
            AddObject(new WallDown(), 130, 944);
            AddObject(new WallDown(), 130, 976);
            AddObject(new WallDown(), 130, 1008);
            AddObject(new WallDown(), 130, 1040);
            AddObject(new WallDown(), 130, 1072);
            AddObject(new WallDown(), 130, 816);
            AddObject(new WallDown(), 130, 1088);
            AddObject(new WallDown(), 2, 1148);
            AddObject(new WallDown(), 2, 1172);
            AddObject(new WallDown(), 130, 1216);
            AddObject(new WallDown(), 130, 1248);
            AddObject(new WallDown(), 130, 1280);
            AddObject(new WallDown(), 130, 1312);
            AddObject(new WallDown(), 130, 1344);
            AddObject(new WallDown(), 130, 1376);
            AddObject(new WallDown(), 130, 1408);
            AddObject(new WallDown(), 240, 1312);
            AddObject(new WallDown(), 305, 1264);
            AddObject(new WallDown(), 305, 1232);
            AddObject(new WallDown(), 240, 1184);
            AddObject(new WallDown(), 240, 992);
            AddObject(new WallDown(), 240, 1008);
            AddObject(new WallDown(), 240, 1152);
            AddObject(new WallDown(), 240, 1120);
            AddObject(new WallDown(), 240, 1088);
            AddObject(new WallDown(), 240, 1055);
            AddObject(new WallDown(), 240, 960);
            AddObject(new WallDown(), 240, 928);
            AddObject(new WallDown(), 240, 896);
            AddObject(new WallDown(), 240, 752);
            AddObject(new WallDown(), 240, 720);
            AddObject(new WallDown(), 240, 576);
            AddObject(new WallDown(), 240, 544);
            AddObject(new WallDown(), 240, 512);
            AddObject(new WallDown(), 240, 480);
            AddObject(new WallDown(), 482, 576);
            AddObject(new WallDown(), 482, 544);
            AddObject(new WallDown(), 482, 512);
            AddObject(new WallDown(), 482, 480);
            AddObject(new WallDown(), 482, 448);
            AddObject(new WallDown(), 482, 416);
            AddObject(new WallDown(), 482, 384);
            AddObject(new WallDown(), 482, 352);
            AddObject(new WallDown(), 482, 320);
            AddObject(new WallDown(), 482, 288);
            AddObject(new WallDown(), 482, 256);
            AddObject(new WallDown(), 482, 224);
            AddObject(new WallDown(), 482, 192);
            AddObject(new WallDown(), 482, 160);
            AddObject(new WallDown(), 482, 128);
            AddObject(new WallDown(), 482, 96);
            AddObject(new WallDown(), 370, 64);
            AddObject(new WallDown(), 370, 32);
            AddObject(new WallDown(), 370, 16);
            AddObject(new WallDown(), 592, 16);
            AddObject(new WallDown(), 592, 48);
            AddObject(new WallDown(), 592, 80);
            AddObject(new WallDown(), 592, 112);
            AddObject(new WallDown(), 592, 144);
            AddObject(new WallDown(), 592, 176);
            AddObject(new WallDown(), 592, 208);
            AddObject(new WallDown(), 592, 240);
            AddObject(new WallDown(), 592, 272);
            AddObject(new WallDown(), 592, 304);
            AddObject(new WallDown(), 592, 336);
            AddObject(new WallDown(), 592, 368);
            AddObject(new WallDown(), 592, 400);
            AddObject(new WallDown(), 592, 432);
            AddObject(new WallDown(), 592, 464);
            AddObject(new WallDown(), 592, 496);
            AddObject(new WallDown(), 592, 528);
            AddObject(new WallDown(), 592, 560);
            AddObject(new WallDown(), 592, 592);
            AddObject(new WallDown(), 592, 624);
            AddObject(new WallDown(), 592, 656);
            AddObject(new WallDown(), 592, 688);
            AddObject(new WallDown(), 432, 736);
            AddObject(new WallDown(), 432, 768);
            AddObject(new WallDown(), 432, 800);
            AddObject(new WallDown(), 432, 832);
            AddObject(new WallDown(), 432, 864);
            AddObject(new WallDown(), 322, 752);
            AddObject(new WallDown(), 322, 720);
            AddObject(new WallDown(), 402, 1472);
            AddObject(new WallDown(), 402, 1504);
            AddObject(new WallDown(), 402, 1536);
            AddObject(new WallDown(), 402, 1568);
            AddObject(new WallDown(), 402, 1600);
            AddObject(new WallDown(), 402, 1632);
            AddObject(new WallDown(), 402, 1664);
            AddObject(new WallDown(), 402, 1696);
            AddObject(new WallDown(), 402, 1712);
            AddObject(new WallDown(), 226, 1696);
            AddObject(new WallDown(), 226, 1664);
            AddObject(new WallDown(), 226, 1632);
            AddObject(new WallDown(), 226, 1600);
            AddObject(new WallDown(), 382, 1552);
            AddObject(new WallDown(), 382, 1520);
            AddObject(new WallDown(), 382, 1504);
            AddObject(new WallDown(), 114, 1472);
            AddObject(new WallDown(), 114, 1504);
            AddObject(new WallDown(), 114, 1536);
            AddObject(new WallDown(), 114, 1568);
            AddObject(new WallDown(), 114, 1600);
            AddObject(new WallDown(), 114, 1632);
            AddObject(new WallDown(), 114, 1664);
            AddObject(new WallDown(), 114, 1696);
            AddObject(new WallDown(), 114, 1728);
            AddObject(new WallDown(), 114, 1760);
            AddObject(new WallDown(), 114, 1792);
            AddObject(new WallDown(), 114, 1808);
            AddObject(new WallDown(), 512, 1824);
            AddObject(new WallDown(), 512, 1792);
            AddObject(new WallDown(), 512, 1760);
            AddObject(new WallDown(), 512, 1728);
            AddObject(new WallDown(), 512, 1696);
            AddObject(new WallDown(), 512, 1664);
            AddObject(new WallDown(), 512, 1632);
            AddObject(new WallDown(), 512, 1600);
            AddObject(new WallDown(), 512, 1568);
            AddObject(new WallDown(), 512, 1536);
            AddObject(new WallDown(), 512, 1504);
            AddObject(new WallDown(), 512, 1472);
            AddObject(new WallDown(), 512, 1456);
            AddObject(new WallDown(), 594, 1664);
            AddObject(new WallDown(), 594, 1632);
            AddObject(new WallDown(), 594, 1600);
            AddObject(new WallDown(), 594, 1568);
            AddObject(new WallDown(), 594, 1536);
            AddObject(new WallDown(), 594, 1504);
            AddObject(new WallDown(), 594, 1472);
            AddObject(new WallDown(), 594, 1456);
            AddObject(new WallDown(), 848, 1680);
            AddObject(new WallDown(), 848, 1648);
            AddObject(new WallDown(), 848, 1616);
            AddObject(new WallDown(), 705, 1552);
            AddObject(new WallDown(), 705, 1520);
            AddObject(new WallDown(), 705, 1488);
            AddObject(new WallDown(), 705, 1456);
            AddObject(new WallDown(), 719, 1456);
            AddObject(new WallDown(), 733, 1456);
            AddObject(new WallDown(), 740, 1456);
            AddObject(new WallDown(), 752, 1456);
            AddObject(new WallDown(), 752, 1424);
            AddObject(new WallDown(), 752, 1392);
            AddObject(new WallDown(), 752, 1360);
            AddObject(new WallDown(), 752, 1328);
            AddObject(new WallDown(), 752, 1312);
            AddObject(new WallDown(), 766, 1312);
            AddObject(new WallDown(), 780, 1312);
            AddObject(new WallDown(), 786, 1312);
            AddObject(new WallDown(), 786, 1344);
            AddObject(new WallDown(), 786, 1376);
            AddObject(new WallDown(), 786, 1408);
            AddObject(new WallDown(), 786, 1440);
            AddObject(new WallDown(), 896, 1456);
            AddObject(new WallDown(), 896, 1424);
            AddObject(new WallDown(), 896, 1392);
            AddObject(new WallDown(), 896, 1360);
            AddObject(new WallDown(), 896, 1328);
            AddObject(new WallDown(), 896, 1312);
            AddObject(new WallDown(), 1090, 1312);
            AddObject(new WallDown(), 1090, 1344);
            AddObject(new WallDown(), 1090, 1376);
            AddObject(new WallDown(), 994, 1392);
            AddObject(new WallDown(), 994, 1424);
            AddObject(new WallDown(), 994, 1456);
            AddObject(new WallDown(), 994, 1488);
            AddObject(new WallDown(), 1090, 1536);
            AddObject(new WallDown(), 1090, 1552);
            AddObject(new WallDown(), 898, 1568);
            AddObject(new WallDown(), 898, 1568);
            AddObject(new WallDown(), 898, 1600);
            AddObject(new WallDown(), 898, 1632);
            AddObject(new WallDown(), 898, 1664);
            AddObject(new WallDown(), 898, 1696);
            AddObject(new WallDown(), 898, 1726);
            AddObject(new WallDown(), 802, 1744);
            AddObject(new WallDown(), 802, 1776);
            AddObject(new WallDown(), 802, 1808);
            AddObject(new WallDown(), 802, 1824);
            AddObject(new WallDown(), 1008, 1840);
            AddObject(new WallDown(), 1008, 1808);
            AddObject(new WallDown(), 1008, 1776);
            AddObject(new WallDown(), 1008, 1744);
            AddObject(new WallDown(), 1008, 1712);
            AddObject(new WallDown(), 1200, 1680);
            AddObject(new WallDown(), 1200, 1648);
            AddObject(new WallDown(), 1200, 1616);
            AddObject(new WallDown(), 1200, 1584);
            AddObject(new WallDown(), 1200, 1552);
            AddObject(new WallDown(), 1200, 1520);
            AddObject(new WallDown(), 1200, 1488);
            AddObject(new WallDown(), 1200, 1456);
            AddObject(new WallDown(), 1200, 1424);
            AddObject(new WallDown(), 1200, 1392);
            AddObject(new WallDown(), 1200, 1360);
            AddObject(new WallDown(), 1200, 1328);
            AddObject(new WallDown(), 1200, 1296);
            AddObject(new WallDown(), 1200, 1264);
            AddObject(new WallDown(), 1200, 1232);
            AddObject(new WallDown(), 1200, 1200);
            AddObject(new WallDown(), 912, 1152);
            AddObject(new WallDown(), 912, 1120);
            AddObject(new WallDown(), 912, 1088);
            AddObject(new WallDown(), 912, 1056);
            AddObject(new WallDown(), 912, 1024);
            AddObject(new WallDown(), 912, 992);
            AddObject(new WallDown(), 1410, 992);
            AddObject(new WallDown(), 1282, 1040);
            AddObject(new WallDown(), 1282, 1072);
            AddObject(new WallDown(), 1282, 1104);
            AddObject(new WallDown(), 1282, 1136);
            AddObject(new WallDown(), 1282, 1168);
            AddObject(new WallDown(), 1282, 1200);
            AddObject(new WallDown(), 1282, 1232);
            AddObject(new WallDown(), 1518, 1232);
            AddObject(new WallDown(), 1518, 1200);
            AddObject(new WallDown(), 1518, 1168);
            AddObject(new WallDown(), 1518, 1136);
            AddObject(new WallDown(), 1518, 1104);
            AddObject(new WallDown(), 1518, 1072);
            AddObject(new WallDown(), 1518, 1040);
            AddObject(new WallDown(), 1518, 1008);
            AddObject(new WallDown(), 1518, 976);
            AddObject(new WallDown(), 1518, 944);
            AddObject(new WallDown(), 1518, 912);
            AddObject(new WallDown(), 1518, 896);
            AddObject(new WallDown(), 800, 832);
            AddObject(new WallDown(), 800, 800);
            AddObject(new WallDown(), 800, 768);
            AddObject(new WallDown(), 800, 736);
            AddObject(new WallDown(), 800, 704);
            AddObject(new WallDown(), 800, 672);
            AddObject(new WallDown(), 800, 640);
            AddObject(new WallDown(), 800, 608);
            AddObject(new WallDown(), 800, 576);
            AddObject(new WallDown(), 800, 544);
            AddObject(new WallDown(), 800, 528);
            AddObject(new WallDown(), 1026, 528);
            AddObject(new WallDown(), 1026, 560);
            AddObject(new WallDown(), 1026, 592);
            AddObject(new WallDown(), 1026, 624);
            AddObject(new WallDown(), 1026, 640);
            AddObject(new WallDown(), 930, 656);
            AddObject(new WallDown(), 930, 688);
            AddObject(new WallDown(), 930, 720);
            AddObject(new WallDown(), 930, 752);
            AddObject(new WallDown(), 1136, 752);
            AddObject(new WallDown(), 1136, 720);
            AddObject(new WallDown(), 1136, 560);
            AddObject(new WallDown(), 1136, 528);
            AddObject(new WallDown(), 1360, 496);
            AddObject(new WallDown(), 1360, 464);
            AddObject(new WallDown(), 1360, 432);
            AddObject(new WallDown(), 1360, 400);
            AddObject(new WallDown(), 1360, 368);
            AddObject(new WallDown(), 1360, 336);
            AddObject(new WallDown(), 1360, 304);
            AddObject(new WallDown(), 1360, 272);
            AddObject(new WallDown(), 1250, 240);
            AddObject(new WallDown(), 1250, 272);
            AddObject(new WallDown(), 1250, 304);
            AddObject(new WallDown(), 1250, 336);
            AddObject(new WallDown(), 1250, 368);
            AddObject(new WallDown(), 1250, 336);
            AddObject(new WallDown(), 1024, 384);
            AddObject(new WallDown(), 1024, 352);
            AddObject(new WallDown(), 1024, 368);
            AddObject(new WallDown(), 1024, 368);
            AddObject(new WallDown(), 1024, 304);
            AddObject(new WallDown(), 1024, 272);
            AddObject(new WallDown(), 1024, 240);
            AddObject(new WallDown(), 1024, 208);
            AddObject(new WallDown(), 1024, 176);
            AddObject(new WallDown(), 1024, 144);
            AddObject(new WallDown(), 1024, 112);
            AddObject(new WallDown(), 1024, 80);
            AddObject(new WallDown(), 738, 48);
            AddObject(new WallDown(), 738, 80);
            AddObject(new WallDown(), 738, 112);
            AddObject(new WallDown(), 738, 128);
            AddObject(new WallDown(), 914, 176);
            AddObject(new WallDown(), 914, 208);
            AddObject(new WallDown(), 914, 240);
            AddObject(new WallDown(), 914, 272);
            AddObject(new WallDown(), 914, 304);
            AddObject(new WallDown(), 914, 336);
            AddObject(new WallDown(), 914, 368);
            AddObject(new WallDown(), 914, 384);
            AddObject(new WallDown(), 690, 400);
            AddObject(new WallDown(), 690, 432);
            AddObject(new WallDown(), 690, 464);
            AddObject(new WallDown(), 690, 496);
            AddObject(new WallDown(), 690, 528);
            AddObject(new WallDown(), 690, 560);
            AddObject(new WallDown(), 690, 592);
            AddObject(new WallDown(), 690, 624);
            AddObject(new WallDown(), 690, 656);
            AddObject(new WallDown(), 690, 688);
            AddObject(new WallDown(), 690, 720);
            AddObject(new WallDown(), 690, 736);
            AddObject(new WallDown(), 594, 752);
            AddObject(new WallDown(), 594, 784);
            AddObject(new WallDown(), 594, 816);
            AddObject(new WallDown(), 594, 848);
            AddObject(new WallDown(), 690, 896);
            AddObject(new WallDown(), 690, 928);
            AddObject(new WallDown(), 690, 960);
            AddObject(new WallDown(), 802, 992);
            AddObject(new WallDown(), 802, 1024);
            AddObject(new WallDown(), 802, 1056);
            AddObject(new WallDown(), 802, 1088);
            AddObject(new WallDown(), 802, 1120);
            AddObject(new WallDown(), 802, 1152);
            AddObject(new WallDown(), 802, 1168);
            AddObject(new WallDown(), 752, 1152);
            AddObject(new WallDown(), 752, 1120);
            AddObject(new WallDown(), 752, 1088);
            AddObject(new WallDown(), 656, 1024);
            AddObject(new WallDown(), 656, 992);
            AddObject(new WallDown(), 656, 960);
            AddObject(new WallDown(), 514, 944);
            AddObject(new WallDown(), 514, 976);
            AddObject(new WallDown(), 514, 1008);
            AddObject(new WallDown(), 514, 1040);
            AddObject(new WallDown(), 306, 1056);
            AddObject(new WallDown(), 306, 1088);
            AddObject(new WallDown(), 306, 1120);
            AddObject(new WallDown(), 306, 1152);
            AddObject(new WallDown(), 306, 1184);
            AddObject(new WallDown(), 416, 1184);
            AddObject(new WallDown(), 416, 1216);
            AddObject(new WallDown(), 416, 1248);
            AddObject(new WallDown(), 416, 1280);
            AddObject(new WallDown(), 416, 1312);
            AddObject(new WallDown(), 642, 1184);
            AddObject(new WallDown(), 642, 1216);
            AddObject(new WallDown(), 642, 1248);
            AddObject(new WallDown(), 642, 1280);
            AddObject(new WallDown(), 642, 1312);































            // Wall Spawning - Down (END)

            // Wall Spawning - Top


            AddObject(new WallAcrossTop(), 16, -16);
            AddObject(new WallAcrossTop(), 64, -16);
            AddObject(new WallAcrossTop(), 112, -16);
            AddObject(new WallAcrossTop(), 160, -16);
            AddObject(new WallAcrossTop(), 208, -16);
            AddObject(new WallAcrossTop(), 256, -16);
            AddObject(new WallAcrossTop(), 240, 352);
            AddObject(new WallAcrossTop(), 288, 352);
            AddObject(new WallAcrossTop(), 304, 352);
            AddObject(new WallAcrossTop(), 32, 464);
            AddObject(new WallAcrossTop(), 80, 464);
            AddObject(new WallAcrossTop(), 96, 464);
            AddObject(new WallAcrossTop(), 16, 688);
            AddObject(new WallAcrossTop(), 64, 688);
            AddObject(new WallAcrossTop(), 88, 688);
            AddObject(new WallAcrossTop(), 0, 1136);
            AddObject(new WallAcrossTop(), 16, 1104);
            AddObject(new WallAcrossTop(), 48, 1104);
            AddObject(new WallAcrossTop(), 82, 1104);
            AddObject(new WallAcrossTop(), 240, 1327);
            AddObject(new WallAcrossTop(), 271, 1327);
            AddObject(new WallAcrossTop(), 240, 1216);
            AddObject(new WallAcrossTop(), 272, 1216);
            AddObject(new WallAcrossTop(), 240, 592);
            AddObject(new WallAcrossTop(), 288, 592);
            AddObject(new WallAcrossTop(), 320, 592);
            AddObject(new WallAcrossTop(), 368, 592);
            AddObject(new WallAcrossTop(), 400, 592);
            AddObject(new WallAcrossTop(), 332, 592);
            AddObject(new WallAcrossTop(), 448, 592);
            AddObject(new WallAcrossTop(), 368, -16);
            AddObject(new WallAcrossTop(), 400, -16);
            AddObject(new WallAcrossTop(), 432, -16);
            AddObject(new WallAcrossTop(), 464, -16);
            AddObject(new WallAcrossTop(), 496, -16);
            AddObject(new WallAcrossTop(), 528, -16);
            AddObject(new WallAcrossTop(), 560, -16);
            AddObject(new WallAcrossTop(), 254, 768);
            AddObject(new WallAcrossTop(), 286, 768);
            AddObject(new WallAcrossTop(), 368, 1728);
            AddObject(new WallAcrossTop(), 336, 1728);
            AddObject(new WallAcrossTop(), 304, 1728);
            AddObject(new WallAcrossTop(), 272, 1728);
            AddObject(new WallAcrossTop(), 240, 1728);
            AddObject(new WallAcrossTop(), 226, 1728);
            AddObject(new WallAcrossTop(), 350, 1472);
            AddObject(new WallAcrossTop(), 320, 1472);
            AddObject(new WallAcrossTop(), 288, 1472);
            AddObject(new WallAcrossTop(), 256, 1472);
            AddObject(new WallAcrossTop(), 224, 1472);
            AddObject(new WallAcrossTop(), 192, 1472);
            AddObject(new WallAcrossTop(), 160, 1472);
            AddObject(new WallAcrossTop(), 128, 1472);
            AddObject(new WallAcrossTop(), 816, 1584);
            AddObject(new WallAcrossTop(), 784, 1584);
            AddObject(new WallAcrossTop(), 752, 1584);
            AddObject(new WallAcrossTop(), 720, 1584);
            AddObject(new WallAcrossTop(), 705, 1584);
            AddObject(new WallAcrossTop(), 1056, 1392);
            AddObject(new WallAcrossTop(), 1024, 1392);
            AddObject(new WallAcrossTop(), 1008, 1392);
            AddObject(new WallAcrossTop(), 1056, 1568);
            AddObject(new WallAcrossTop(), 1024, 1568);
            AddObject(new WallAcrossTop(), 992, 1568);
            AddObject(new WallAcrossTop(), 960, 1568);
            AddObject(new WallAcrossTop(), 928, 1568);
            AddObject(new WallAcrossTop(), 896, 1568);
            AddObject(new WallAcrossTop(), 864, 1744);
            AddObject(new WallAcrossTop(), 832, 1744);
            AddObject(new WallAcrossTop(), 800, 1744);
            AddObject(new WallAcrossTop(), 1168, 1184);
            AddObject(new WallAcrossTop(), 1136, 1184);
            AddObject(new WallAcrossTop(), 1104, 1184);
            AddObject(new WallAcrossTop(), 1072, 1184);
            AddObject(new WallAcrossTop(), 1040, 1184);
            AddObject(new WallAcrossTop(), 1008, 1184);
            AddObject(new WallAcrossTop(), 976, 1184);
            AddObject(new WallAcrossTop(), 944, 1184);
            AddObject(new WallAcrossTop(), 912, 1184);
            AddObject(new WallAcrossTop(), 1378, 1040);
            AddObject(new WallAcrossTop(), 1346, 1040);
            AddObject(new WallAcrossTop(), 1314, 1040);
            AddObject(new WallAcrossTop(), 1296, 1040);
            AddObject(new WallAcrossTop(), 1484, 864);
            AddObject(new WallAcrossTop(), 1484, 864);
            AddObject(new WallAcrossTop(), 1452, 864);
            AddObject(new WallAcrossTop(), 1420, 864);
            AddObject(new WallAcrossTop(), 1388, 864);
            AddObject(new WallAcrossTop(), 1356, 864);
            AddObject(new WallAcrossTop(), 1324, 864);
            AddObject(new WallAcrossTop(), 1292, 864);
            AddObject(new WallAcrossTop(), 1250, 864);
            AddObject(new WallAcrossTop(), 1228, 864);
            AddObject(new WallAcrossTop(), 1196, 864);
            AddObject(new WallAcrossTop(), 1164, 864);
            AddObject(new WallAcrossTop(), 1132, 864);
            AddObject(new WallAcrossTop(), 1100, 864);
            AddObject(new WallAcrossTop(), 1068, 864);
            AddObject(new WallAcrossTop(), 1036, 864);
            AddObject(new WallAcrossTop(), 1004, 864);
            AddObject(new WallAcrossTop(), 972, 864);
            AddObject(new WallAcrossTop(), 940, 864);
            AddObject(new WallAcrossTop(), 908, 864);
            AddObject(new WallAcrossTop(), 876, 864);
            AddObject(new WallAcrossTop(), 844, 864);
            AddObject(new WallAcrossTop(), 812, 864);
            AddObject(new WallAcrossTop(), 800, 864);
            AddObject(new WallAcrossTop(), 992, 656);
            AddObject(new WallAcrossTop(), 960, 656);
            AddObject(new WallAcrossTop(), 944, 656);
            AddObject(new WallAcrossTop(), 1216, 592);
            AddObject(new WallAcrossTop(), 1184, 592);
            AddObject(new WallAcrossTop(), 1152, 592);
            AddObject(new WallAcrossTop(), 1136, 592);
            AddObject(new WallAcrossTop(), 1328, 240);
            AddObject(new WallAcrossTop(), 1296, 240);
            AddObject(new WallAcrossTop(), 1264, 240);
            AddObject(new WallAcrossTop(), 1216, 400);
            AddObject(new WallAcrossTop(), 1184, 400);
            AddObject(new WallAcrossTop(), 1152, 400);
            AddObject(new WallAcrossTop(), 1120, 400);
            AddObject(new WallAcrossTop(), 1088, 400);
            AddObject(new WallAcrossTop(), 1056, 400);
            AddObject(new WallAcrossTop(), 1024, 400);
            AddObject(new WallAcrossTop(), 922, 48);
            AddObject(new WallAcrossTop(), 954, 48);
            AddObject(new WallAcrossTop(), 990, 48);
            AddObject(new WallAcrossTop(), 960, 48);
            AddObject(new WallAcrossTop(), 928, 48);
            AddObject(new WallAcrossTop(), 896, 48);
            AddObject(new WallAcrossTop(), 864, 48);
            AddObject(new WallAcrossTop(), 832, 48);
            AddObject(new WallAcrossTop(), 800, 48);
            AddObject(new WallAcrossTop(), 768, 48);
            AddObject(new WallAcrossTop(), 752, 48);
            AddObject(new WallAcrossTop(), 880, 400);
            AddObject(new WallAcrossTop(), 848, 400);
            AddObject(new WallAcrossTop(), 816, 400);
            AddObject(new WallAcrossTop(), 784, 400);
            AddObject(new WallAcrossTop(), 752, 400);
            AddObject(new WallAcrossTop(), 720, 400);
            AddObject(new WallAcrossTop(), 704, 400);
            AddObject(new WallAcrossTop(), 654, 752);
            AddObject(new WallAcrossTop(), 624, 752);
            AddObject(new WallAcrossTop(), 608, 752);
            AddObject(new WallAcrossTop(), 768, 1184);
            AddObject(new WallAcrossTop(), 752, 1184);
            AddObject(new WallAcrossTop(), 720, 1056);
            AddObject(new WallAcrossTop(), 688, 1056);
            AddObject(new WallAcrossTop(), 656, 1056);
            AddObject(new WallAcrossTop(), 624, 944);
            AddObject(new WallAcrossTop(), 592, 944);
            AddObject(new WallAcrossTop(), 560, 944);
            AddObject(new WallAcrossTop(), 528, 944);
            AddObject(new WallAcrossTop(), 530, 944);
            AddObject(new WallAcrossTop(), 480, 1056);
            AddObject(new WallAcrossTop(), 448, 1056);
            AddObject(new WallAcrossTop(), 416, 1056);
            AddObject(new WallAcrossTop(), 384, 1056);
            AddObject(new WallAcrossTop(), 352, 1056);
            AddObject(new WallAcrossTop(), 320, 1056);
            AddObject(new WallAcrossTop(), 608, 1328);
            AddObject(new WallAcrossTop(), 576, 1328);
            AddObject(new WallAcrossTop(), 544, 1328);
            AddObject(new WallAcrossTop(), 512, 1328);
            AddObject(new WallAcrossTop(), 480, 1328);
            AddObject(new WallAcrossTop(), 448, 1328);
            AddObject(new WallAcrossTop(), 416, 1328);
            // Wall Spawning - Top (END)
        }
    }
    
}
