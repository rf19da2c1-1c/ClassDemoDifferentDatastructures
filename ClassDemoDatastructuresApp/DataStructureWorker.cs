using System;
using System.Collections.Generic;
using System.Net;
using DatastructureLib.model;

namespace ClassDemoDatastructuresApp
{
    internal class DataStructureWorker
    {
        private readonly ICollection<Item> data;

        public DataStructureWorker()
        {
            data = new List<Item>(){
                new Item(1,"Vibeke"),
                new Item(2,"Nilma"),
                new Item(3,"Charlotte"),
                new Item(4,"Poul"),
                new Item(5,"Martin"),
                new Item(6,"Jamshid"),
                new Item(7,"Homayoon"),
                new Item(8,"Jens Peter"),
                new Item(9,"Jakob"),
                new Item(10,"Mohammed"),
                new Item(11,"Michael C"),
                new Item(12,"Peter"),
                new Item(13,"Ivan"),
                new Item(14,"Anders"),
                new Item(15,"Henrik"),
                new Item(16,"Per"),
                new Item(17,"Peter S")
            };
        }

        public void Start()
        {
            //DemoArray();

            //DemoList();

            //DemoDictionary();

            //DemoLinkedList();

            //DemoQueue(); // FIFO

            //DemoStack(); // LIFO

            DemoHashSet();

        }

        private void DemoArray()
        {
            Item[] iarray = new Item[20];
            int ix = 0;

            foreach (Item i in data)
            {
                iarray[ix++] = i;
            }

            for (int i = 0; i < ix; i++)
            {
                Console.WriteLine(iarray[i]);
            }

        }

        private void DemoList()
        {
            List<Item> litem = new List<Item>(data);

            litem.Add(new Item(22, "Ulla"));

            foreach (Item i in litem)
            {
                Console.WriteLine(i);
            }

            bool slettet = litem.Remove(new Item(22, "Ulla"));
            Console.WriteLine("er slettet " + slettet);



        }

        private void DemoDictionary()
        {
            Dictionary<int, Item> ditem = new Dictionary<int, Item>();
            foreach (Item i in data)
            {
                
                ditem.Add(i.Id, i);
            }

            foreach (KeyValuePair<int, Item> pair in ditem)
            {
                Console.WriteLine(pair.Value);
            }

            Console.WriteLine("Version 2");

            foreach (Item i in ditem.Values)
            {
                Console.WriteLine(i);
            }

            // nummer 15
            Console.WriteLine(ditem[15]);


        }

        private void DemoLinkedList()
        {
            LinkedList<Item> llItem = new LinkedList<Item>(data);

            foreach (Item i in llItem)
            {
                Console.WriteLine(i);
            }
            
            

        }

        private void DemoQueue()
        {
            Queue<Item> qitem = new Queue<Item>(data);
            qitem.Enqueue(new Item(0, "Ulla"));

            
            Console.WriteLine(qitem.Dequeue());

            Console.WriteLine("Køen efter ");

            foreach (Item i in qitem)
            {
                Console.WriteLine(i);
            }

            
        }

        private void DemoStack()
        {
            Stack<Item> sitem = new Stack<Item>(data);

            sitem.Push(new Item(20, "Ulla"));
            Item iud = sitem.Pop();
            Console.WriteLine(iud);

            Console.WriteLine("Efter pop");

            foreach (Item i in sitem)
            {
                Console.WriteLine(i);
            }
        }

        private void DemoHashSet()
        {
            HashSet<Item> hitem = new HashSet<Item>(data);

            

            Item i = new Item(20, "Ulla");
            
            bool indsat = hitem.Add(i);
            Console.WriteLine("Ulla indsat i set " + indsat);

            indsat = hitem.Add(i);
            Console.WriteLine("Ulla indsat i set " + indsat);

            indsat = hitem.Add(new Item(8, "Ulla"));
            Console.WriteLine("Ulla indsat i set " + indsat);

            foreach (Item item in hitem)
            {
                Console.Write("Hashcode " + item.GetHashCode() + "  ");

                Console.WriteLine(item);
            }
        }

    }
}