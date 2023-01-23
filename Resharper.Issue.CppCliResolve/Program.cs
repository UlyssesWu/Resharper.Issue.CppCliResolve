using System;
using FreeMote;

namespace Resharper.Issue.CppCliResolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following line is red if ReSharper enabled.");
            var emote = new Emote(IntPtr.Zero, 100, 100);
            emote.ChallengeResharper();
            Console.WriteLine("BuIt builds without error.");
            Console.ReadLine();
        }
    }
}