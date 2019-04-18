using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(25);
            tree.Add(5);
            tree.Add(45);
            tree.Add(50);
            tree.Add(10);
            tree.Add(15);
            tree.Add(30);
            tree.Add(20);
            tree.Add(35);
            tree.Add(40);
            string search = tree.Search(35);
            Console.WriteLine(search);

        }
    }
}
