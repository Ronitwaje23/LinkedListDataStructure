using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        
        static void Main(string[] args)
         {

            Console.WriteLine("Welcome to Linked List");
            LinkedList1 list2 = new LinkedList1();
            //Appends the Nodes
            list2.AddFirst(56);
            list2.AddFirst(30);
            list2.AddFirst(70);

            //Remove first node 50 from the linked list
            list2.RemoveFirstNode();
            list2.Display();
            //Removed Last Node 70 from the linked list
            Console.WriteLine("Removed the last node from the linked list");
            LinkedList1 list5 = new LinkedList1();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.RemovaLastNode();
            list5.Display();
            //Search Node 30 from the given liked list
            Console.WriteLine("Searching the Nodes");
            LinkedList1 list6 = new LinkedList1();
            list6.Add(40);
            list6.Add(30);
            list6.Add(70);
            //remove Node 40

            list6.RemoveNodeAtParticularPosition(1);
            list6.Display();
            Console.ReadKey();
            //Create a sorted linked list in ascending order
            Console.WriteLine("create a sorted linked list in acsending order");
            LinkedList1 list7 = new LinkedList1();
            list7.Add(56);
            list7.Add(30);
            list7.Add(40);
            list7.Add(70);
            Console.WriteLine("Before Sorting ");
            list7.Display();
            Console.WriteLine("After Sorting");
            list7.sortList();
            list7.Display();
            Console.ReadLine();
        }
    }
}









