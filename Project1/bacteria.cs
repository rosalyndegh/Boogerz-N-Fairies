using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Bacteria
    {
        private int flagellaCount;
        public Bacteria()
        {
            Nucleus nucleus = new Nucleus(0, 0);
            flagellaCount = 15;

            Console.Write(String.Format("Bacteria:\n"));
            Console.Write(String.Format("   Flagella: {0}\n", flagellaCount));
            Console.Write(String.Format("   nucleus: {0}, {1}, {2}\n", nucleus.EnzymeCount, nucleus.NucleotideCount, nucleus.Color));

           
           
        }
       
    }
}
