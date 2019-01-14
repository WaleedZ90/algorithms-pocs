using Algorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class DepthFirstSearch
    {
        public static void Preorder(Node node, int level = 0)
        {
            var indent = new string(' ', 3 * level);
            Console.WriteLine("{0}{1}", indent, node.Name);

            foreach (var child in node.Children)
                Preorder(child, level + 1);
        }

        public static void PostOrder(Node node, int level = 0)
        {
            foreach (var child in node.Children)
                Preorder(child, level + 1);

            var indent = new string(' ', 3 * level);
            Console.WriteLine("{0}{1}", indent, node.Name);
        }
    }
}
