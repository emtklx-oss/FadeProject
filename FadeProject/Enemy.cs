using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FadeProject
{
    internal class Enemy : WorldObject
    {
        public Enemy(Point pos, Size size, ObjectType type = ObjectType.None) : base(pos, size, type)
        {
        }
    }
}
