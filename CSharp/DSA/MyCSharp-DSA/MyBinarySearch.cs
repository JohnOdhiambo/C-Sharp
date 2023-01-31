using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    //A tree structure is useful for working with non linear data
    //It is a collection of nodes, where each node might be linked to one, two or even more nodes
    //It is a collection of nodes that are connected by links
    class MyBinarySearch
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }
        class BinarySearchTree
        {
            //Algorithm to add data to a node in a Binary Search tree manner
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;

                }
                else
                {
                    //if root is not null, insert on either the left or right side
                    if (value < root.Data)
                    {
                        //insert on the left
                        root.Left = Insert(root.Left, value);
                    }
                    else if (value > root.Data)
                    {
                        //insert on the right
                        root.Right = Insert(root.Right, value);                       
                    }
                }
                return root;
            }
            public static Boolean Contains(Node root, int value)
            {
                if (root == null)
                {
                    return false;
                }
                else if (value < root.Data)
                {
                    return Contains(root.Left, value);
                }
                else if (value > root.Data)
                {
                    return Contains(root.Right, value);
                }
                else
                {
                    return true;
                }

            }
        }

        static void Main(string[] args)
        {
            TreeTraversals tree = new TreeTraversals();
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            Console.WriteLine("The Result is:");
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 5));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 6));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 2));

            Console.WriteLine(BinarySearchTree.Contains(rootNode, 0));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -4));
            Console.WriteLine(BinarySearchTree.Contains(null, 4));

        }

    }

}
