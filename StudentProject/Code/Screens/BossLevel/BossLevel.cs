using Microsoft.Xna.Framework;
using MonoGameEngine;
using MonoGameEngine.StandardCore;
using StudentProject.Code.GameObjects;


namespace StudentProject.Code.Screens
{
    public class BossLevel : Screen
    {
        Text _score;
        DanniFinalBoss _player;
        HealthDisplay _healthDisplay;
        EnemyHealthDisplay _enemyHealthDisplay;
        Boss _boss;           
        EndGameDoor _endGameDoor;
         SpellBook _spellBook;



        public override void Start(Core core)
        {
            base.Start(core);
            // TODO: Add your Screen starting code below here

            SetBackground("Boss Background");
            Transition.Instance.EndTransition();
            AudioManager.Instance.PlayBGM("Boss music");
            Settings.ScreenDimensions = new Vector2(1920, 1080);

            _player = new DanniFinalBoss();
            AddObject(_player, 260, 710);

            _boss = new Boss();
            AddObject(_boss, 860, 160);

            _score = new Text("Score: 0", Color.White);
            AddText(_score, 30, 20);

            _healthDisplay = new HealthDisplay();
            AddObject(_healthDisplay, 20, 50);

            _enemyHealthDisplay = new EnemyHealthDisplay(); 
            AddObject(_enemyHealthDisplay, 1760, 30);

            _spellBook = new SpellBook();
            AddObject(_spellBook, 0, 0);
            GameInput.SetMousePosition(core.GraphicsDevice.Viewport.Bounds.Center.ToVector2());

            BuildGrass();
           
        }

        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
            // TODO: Add your Screen updated code below here
            //spawns door and bonus 
            SpawnBonus();
            SpawnDoor();

            _score.SetMessage("Score: " + _player.GetScore());
            _healthDisplay.SetHealth(_player.Getlives());

            //gets the player enemy lives 
            _enemyHealthDisplay.SetEnemyHealth(_boss.GetEnemylives());

            

        }

        //if the enemy lives is equal too or less than 0 a the endgamedoor is spawned
        private void SpawnDoor()
        {
            int HoldLives = _boss.GetEnemylives();

            if ( HoldLives <= 0)
            {
                _endGameDoor = new EndGameDoor();
                AddObject(_endGameDoor,1700,700); 
            }
        }
       
        // spawns the bonus at a random
        private void SpawnBonus()
        {
            if (Core.GetRandomNumber(600) <= 0)
            {
                AddObject(new Bonus(), Core.GetRandomNumber((int)Settings.ScreenDimensions.X - 84), 160);
            }
        }

        private void BuildGrass()
        {
            int yPosition = (int)Settings.GameResolution.Y - 230;

            int ScreenRightEdge = (int)Settings.GameResolution.X - 980;

            int numberOfGrass = 2;

            int gapBetweenGrass = 0;

            for (int column = 0; column < numberOfGrass; column++)
            {
                int xPosition = column * (64 + gapBetweenGrass);

                AddObject(new Grass(), xPosition, yPosition);

                AddObject(new Grass(), ScreenRightEdge - xPosition, yPosition);
            }
        }
    }
}
