using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW37_3
{
    internal class Part1
    {
        public void AddPart(ImmutableList<string> strings)=>
            Poem = strings.AddRange(new[] { "Вот дом,", "Который построил Джек.", Environment.NewLine});
        public ImmutableList<string> Poem
        {
            get;
            private set;
        }
    }
}
