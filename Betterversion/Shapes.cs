using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Betterversion
{
    public class Shapes
    {
        public int number = 0;
        public string type = " ";

        public static List<Shapes> ReversePyramid()
        {
            List<Shapes> Items = new List<Shapes>
            {

                new Shapes { number = 8, type = "#"},
                new Shapes { number = 1, }, new Shapes { number = 6, type = "#" },new Shapes { number = 1}, // new line
                new Shapes { number = 2 }, new Shapes { number = 4, type = "#" },new Shapes { number = 2, }, // new line
                new Shapes { number = 3 }, new Shapes { number = 2, type = "#" }, new Shapes { number = 3, } // new line
            };
            return Items;
        }

        public static List<Shapes> Diamond()
        {
            var Item = new List<Shapes>(ReversePyramid());
            Item.Reverse();
            var Item2 = new List<Shapes>(ReversePyramid());
            var Items = new List<Shapes> { };
            Item.ForEach(val => {Items.Add(val);});
            Item2.ForEach(val => { Items.Add(val);});
            


            return Items;
        }

        public static List<Shapes> X()
        {
            var Top = new List<Shapes>
            {
                new Shapes { number = 1, type = "#" }, new Shapes { number = 12, }, new Shapes { number = 1, type = "#" }, 
                new Shapes { number = 1 }, new Shapes{number = 2,type = "#"},new Shapes{number = 8},new Shapes{number = 2, type = "#"},new Shapes { number = 1 },
                new Shapes { number = 2 }, new Shapes { number = 3, type = "#" },new Shapes{number = 4}, new Shapes{number = 3, type = "#"}, new Shapes{number = 2},
                new Shapes { number = 3, }, new Shapes{number = 8, type="#"},new Shapes{number = 3}
            };
            var Items = new List<Shapes>(Top);
            Top.Reverse();
            Top.ForEach(val => {Items.Add(val);});
            return Items;
        }
        
    }
}
