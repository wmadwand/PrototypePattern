using System;
using System.Collections.Generic;

namespace Prototype
{
    public class MazeParts
    {
        public MazeParts()
        {
        }

        public enum Direction
        {
            North, South, East, West
        }
    }

    public class MapSite { }

    public class Maze
    {
        private List<Room> _rooms;

        public Maze()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room GetRoom(int number)
        {
            return _rooms[number];
        }
    }

    public class Room : MapSite
    {
        private int _number;
        private MapSite[] _sides = new MapSite[4];

        public Room(int number)
        {
            _number = number;
        }

        public void SetSide() { }
    }

    public class Wall : MapSite
    {
        protected bool _dummyBool;

        public virtual Wall Clone()
        {
            return new Wall(this);
        }

        public Wall(Wall wall)
        {
            _dummyBool = wall._dummyBool;
        }

        public Wall()
        {
        }
    }

    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;

        public Door()
        {
        }

        public void Initialize(Room r1, Room r2)
        {
            _room1 = r1;
            _room2 = r2;
        }

        public Door Clone()
        {
            return new Door(this);
        }

        private Door(Door door)
        {
            _room1 = door._room1;
            _room2 = door._room2;
        }
    }

    // ------------------------------------

    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int number) : base(number)
        {
        }
    }

    public class BombedWall : Wall
    {
        private bool _bomb;

        public override Wall Clone()
        {
            return new BombedWall(this);
        }

        private BombedWall(BombedWall bombedWall) : base(bombedWall)
        {
            _dummyBool = bombedWall._dummyBool;
        }

        public BombedWall()
        {
        }
    }
}