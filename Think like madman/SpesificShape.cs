using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Think_like_madman
{
    public class SpesificShape
    {
        public static void ReversePyramid()
        {
            CreateLine.Create(true, 0, 8,0, 0, true);
            CreateLine.Create(false, 1, 6, 1, 0, false);
            CreateLine.Create(false, 2, 4, 2, 0, false);
            CreateLine.Create(false, 3, 2, 3, 0, false);
        }

        public static void Diamond()
        {
            CreateLine.Create(false, 3, 2, 3, 0, true);
            CreateLine.Create(false, 2, 4, 2, 0, false);
            CreateLine.Create(false, 1, 6, 1, 0, false);
            CreateLine.Create(true, 0, 8, 0, 0, false);
            CreateLine.Create(true, 0, 8, 0, 0, true);
            CreateLine.Create(false, 1, 6, 1, 0, false);
            CreateLine.Create(false, 2, 4, 2, 0, false);
            CreateLine.Create(false, 3, 2, 3, 0, false);
        }

        public static void X()
        {
            CreateLine.Create(true, 6, 1, 0, 1, true);
            CreateLine.Create(false, 1, 4, 2, 2, true);
            CreateLine.Create(false, 1, 6, 1, 0, false);
            CreateLine.Create(true, 0, 8, 0, 0, false);
            CreateLine.Create(true, 0, 8, 0, 0, true);
            CreateLine.Create(false, 1, 6, 1, 0, false);
            CreateLine.Create(false, 2, 4, 2, 0, false);
            CreateLine.Create(false, 3, 2, 3, 0, false);
        }
    }
}
