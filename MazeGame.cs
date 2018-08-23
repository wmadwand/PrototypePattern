using System;
namespace Prototype
{
    public class MazeGame
    {
        public MazeGame()
        {
        }

        public Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();

            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);
            Door door = factory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            return maze;
        }
    }
}
