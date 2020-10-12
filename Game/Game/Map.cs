using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Map
    {

        Random r;
        int mapwidth;
        int mapheight;
        int NumEnemy = 0;
        Tile[,] mapArray;
        List<Enemy> Enemy = new List<Enemy>();
        
        public Map(int NEnemy)
        {
            NumEnemy = NEnemy;
            
        }
        public void MapGen()
        {
            mapwidth = r.Next(5, 50);
            mapheight = r.Next(5, 50);
            NumEnemy = r.Next(mapwidth, mapheight);

            for (int i = 0; i < NumEnemy; i++)
            {
                if (r.Next(0, 2) == 0) 
                {
                    Goblin GE = new Goblin(r.Next(5, 50), r.Next(5, 50),"G");
                    Enemy.Add(GE);
                }
                else  
                {
                    Mage ME = new Mage(r.Next(5, 50), r.Next(5, 50), "M");
                    Enemy.Add(ME);
                }
            }
        }

        public void UpdateVision()
        {

        }

        private Create()
        {

        }

        
    }
}
