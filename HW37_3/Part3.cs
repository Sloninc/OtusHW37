using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW37_3
{
    internal class Part3
    {
        public void AddPart(ImmutableList<string> strings) =>
                   Poem = strings.AddRange(new[] { 
                        "А это веселая птица-синица,",
                        "Которая часто ворует пшеницу,",
                        "Которая в темном чулане хранится",
                        "В доме,",
                        "Который построил Джек.", Environment.NewLine
                   });
        public ImmutableList<string> Poem
        {
            get;
            set;
        }
    }
}
