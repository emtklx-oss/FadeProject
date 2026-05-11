using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadeProject
{
    public enum ObjectType
    {
        None,
        NPC_Enemy,
        NPC_Friendly,
        Player,
        Item,
        Projectile,

    }
    internal class WorldObject
    {
        //Every object in game will be a type of this. 
        private Point Position; {  get; set; }
        public Size ObjSize { get; set; } //Pixel Dimensions. If the object is 32 x 32px this is 32 x 32
        public ObjectType ObjectType { get; private set; }

        public WorldObject(Point pos, Size size, ObjectType type = ObjectType.None )
        {

        }

        public bool TryMove(int deltaX, int deltaY)
        {
            Point tempPos = new Point( Position.X +  deltaX, Position.Y + deltaY );
            if (deltaX <= 0 || deltaY <= 0) return false;
            if ()

            Position = tempPos;
        }
        public bool IsColliding()
        {

            return false;
        }
    }
}
