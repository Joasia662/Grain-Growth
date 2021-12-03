using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    static class logic
    {
        public static int randomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static void addToMap(ref Dictionary<int, int> neighbours, int id)
        {
            if (id != 0)
            {
                if (neighbours.ContainsKey(id))
                    neighbours[id] = neighbours[id] + 1;

                else
                    neighbours.Add(id, 1);
            }
        }

        public static int getBiggestAmount(Dictionary<int, int> data)
        {
            int valueMax = 0;
            int idMax = 0;
            foreach (KeyValuePair<int, int> pair in data)
            {
                if (pair.Value > valueMax)
                {
                    valueMax = pair.Value;
                    idMax = pair.Key;
                }
            }
            return idMax;
        }
      
    }

  
}
