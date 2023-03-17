using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think_like_madman
{
    public class Writer
    {
        public static void write(int number, string which)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(which);
            }
        }
    }
}
