using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class BinarySearchTree
    {
        //Member Variables 
        public Node root;
       




        //Constructor
        public BinarySearchTree()
        {
            root = null;

            

        }
       


        //Member Methods
        public void Add(int i)
        {

            Node newnode = new Node();
            newnode.data = i;
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newnode;
                            break;
                        }
                        
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newnode;
                            break;
                        }

                    }







                }

            }



        }
        public string Search(int i)
        {
            
            
            if (root == null)
            {
                return "The Binary Search Tree does not contain that value!";
            }            
            if (i < root.data)
            {
                root = root.left;
                
                Console.WriteLine("Left");
                return this.Search(i); 
            }
            if (i > root.data)
            {
                root = root.right;
                Console.WriteLine("Right");
                

                return this.Search(i);
            }
            else
            {
                return ($"Found {root.data}!");
            }
        }
    }
}
