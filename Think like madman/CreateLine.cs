using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think_like_madman
{
    public class CreateLine
    {
        public static void Create(bool flinehashash, int fspace, int fhash, int lspace,  int lhash, bool llinehashash)
        {
            //redundant but fun. Could just send into create directly without the object which I did, but fun.
            /* var line = new HashtagSoCool(flinehashash, fspace, lspace, fhash, lhash,llinehashash);*/

            if (!flinehashash)
            {
                Writer.write(fspace, " ");
                Writer.write(fhash, "#");

            }
            else
            {
                Writer.write(fspace, " ");
                Writer.write(fhash, "#");
            }

            if (!flinehashash)
            {

                Writer.write(lspace, " ");
                Writer.write(lhash, "#");

            }
            else
            {
                Writer.write(lspace, " ");
                Writer.write(lhash, "#");
            }
            Console.WriteLine();
        }
    }
}
