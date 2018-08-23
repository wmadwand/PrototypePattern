using System;
namespace Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory()
        {
        }

        public MazePrototypeFactory(Maze prototypeMaze, Room prototypeRoom, Wall prototypeWall, Door prototypeDoor)
        {
            _prototypeMaze = prototypeMaze;
            _prototypeRoom = prototypeRoom;
            _prototypeWall = prototypeWall;
            _prototypeDoor = prototypeDoor;
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(r1, r2);

            return door;
        }

        public override Wall MakeWall()
        {
            return _prototypeWall.Clone();
        }
    }
}
