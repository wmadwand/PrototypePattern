using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void CreateGame()
        {
            Maze maze;
            MazeGame game = new MazeGame();
            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new Room(0), new Wall(), new Door());

            MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(new Maze(), new RoomWithABomb(1), new BombedWall(), new Door());

            maze = game.CreateMaze(simpleMazeFactory);
        }
    }
}
