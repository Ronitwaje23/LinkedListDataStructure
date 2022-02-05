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
            LinkedList1 list = new LinkedList1();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2,30);
            LinkedList1 list2 = new LinkedList1();
            //Appends the Nodes
            list2.AddFirst(56);
            list2.AddFirst(30);
            list2.AddFirst(70);
            list2.Display();
            Console.ReadKey();
            list.Display();
            Console.ReadLine();
        }


    }
}





