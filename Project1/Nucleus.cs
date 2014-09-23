using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Nucleus
    {
        private const String DefaultColor = "Purple";

        public int NucleotideCount { get; set; }
        public int EnzymeCount { get; set; }
        public String Color { get {
            return Nucleus.DefaultColor;
        }
        }

        public Nucleus(int nucleotideCount, int enzymeCount)
        {
            NucleotideCount = nucleotideCount;
            EnzymeCount = enzymeCount;

        }

        public override String ToString()
        {
            return String.Format("nucleus : {0}, {1}, {2}", this.EnzymeCount, this.NucleotideCount, this.Color);
        }
    }
}
