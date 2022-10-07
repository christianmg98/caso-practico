using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico
{
    public class Dado
    {
        private int min = 1;
        private int max = 6;
        

        public Dado()
        {
        }

        public int lanzar()
        {
            Random random = new Random();
            return random.Next(min, max+1);
        }
    }
}
