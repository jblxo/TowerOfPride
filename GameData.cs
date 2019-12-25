using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    public class GameData
    {
        public static GameData Instance = new GameData();
        public int NumOfDisks = 3;
        public GameData() { }
    }
}
