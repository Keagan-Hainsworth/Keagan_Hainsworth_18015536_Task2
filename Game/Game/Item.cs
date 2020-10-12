using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    abstract class Item : Tile
    {
        protected int XPOS
        {
            get;
            set;
        }
        protected int YPOS
        {
            get;
            set;
        }

       abstract virtual string ToString();
    }
}
