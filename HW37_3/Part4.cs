using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW37_3
{
    internal class Part4
    {
        public void AddPart(ImmutableList<string> strings) =>
                    Poem = strings.AddRange(new[] {
                        "Вот кот,",
                        "Который пугает и ловит синицу,",
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
