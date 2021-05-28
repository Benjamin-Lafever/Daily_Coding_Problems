using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(0, 100);
                Node n = new Node(x);
                if (root == null)
                {
                    Console.WriteLine("Setting " + n.label + " to the root");
                    root = n;
                }
                else
                {
                    n.AddNode(root);
                }
            }
        } 
    }
}

//In this program we create a root node 
//it will then assign the inputted data when the Node
//constructor is called in the parenthesis

//once the root node is created you can begin to add new nodes
//using the AddNode() method
//When a new Node object is created and a new data is passed then the AddNode method can be called 

//the new node will then be parsed against the root node, and from there will either be moved 
//down the left or right edges beased on it being greater or lesser then the compared node 

//once the program reaches a null node, it will become the node there