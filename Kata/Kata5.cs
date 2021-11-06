using System.Collections.Generic;

namespace Kata
{
    public static class Kata5
    {
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            // Do your science here :)
            Stack<char> stack = new Stack<char>();
            var result = new Dictionary<string, int>();

            foreach (var item in formula.ToCharArray())
            {
                stack.Push(item);
            }
        }
    }
}
