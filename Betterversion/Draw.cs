using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betterversion
{
    public class Draw
    {
        public static void create(List<Shapes> Items,int length){
            int lineLength = 0;
            foreach (var line in Items)
            {
               
                for (int i = 0; i < line.number; i++)
                {
                    
                    Console.Write(line.type);
                    lineLength++;
                }

                if (lineLength == length)
                {
                    Console.WriteLine();
                    lineLength = 0;
                }
            }
        }
    }
}
