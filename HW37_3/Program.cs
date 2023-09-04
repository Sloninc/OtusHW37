using System.Collections.Immutable;
namespace HW37_3
{
    internal class Program
    {
        static ImmutableList<string> strings = ImmutableList<string>.Empty;
        static void Main()
        {
            Part1 part1 = new Part1();
            part1.AddPart(strings);
            Part2 part2 = new Part2();
            part2.AddPart(part1.Poem);
            Part3 part3 = new Part3();
            part3.AddPart(part2.Poem);
            Part4 part4 = new Part4();
            part4.AddPart(part3.Poem);
            Part5 part5 = new Part5();
            part5.AddPart(part4.Poem);
            Part6 part6 = new Part6();
            part6.AddPart(part5.Poem);
            Part7 part7 = new Part7();
            part7.AddPart(part6.Poem);
            Part8 part8 = new Part8();
            part8.AddPart(part7.Poem);
            Part9 part9 = new Part9();
            part9.AddPart(part8.Poem);
            foreach(var str in part9.Poem)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}