// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Betterversion;

public class Output
{

    public static void Main(string[] args)
    {
        
       Draw.create(Shapes.ReversePyramid(), 8);
       Draw.create(Shapes.Diamond(),8);
       Draw.create(Shapes.X(),14);
    }
}

        
    

    
