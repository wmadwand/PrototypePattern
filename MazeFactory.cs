using System;
using System.Collections.Generic;

namespace Prototype
{
    public class MazeFactory
    {

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int n)
        {
            return new Room(n);
        }

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            return new Door();
        }
    }
}