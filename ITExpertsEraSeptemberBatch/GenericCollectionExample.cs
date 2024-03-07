using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    internal class GenericCollectionExample
    {
        public void ListOperation()
        {
            // Declaration 

            List<string> lstFruits = new List<string>();

            // insert value

            lstFruits.Add("Mangoes");
            lstFruits.Add("Banana");
            lstFruits.Add("Pineapple");
            lstFruits.Add("Grapes");

            // Update Value

            lstFruits[2] = "Pappaya";

            // Read 

            string fruit1 = lstFruits[0];
            string fruit2 = lstFruits[1];
            string fruit3 = lstFruits[2];
            string fruit4 = lstFruits[3];


            // Remove

            lstFruits.Remove("Mangoes");

            lstFruits.RemoveAt(2);

            // 

            int count = lstFruits.Count;

            bool isOrangeExist = lstFruits.Contains("Orange");

            foreach (string fruit in lstFruits)
            {
                Console.WriteLine(fruit);
            }
        }

        public void DictionaryOperation()
        {
            Dictionary<int, string> dictFruits = new Dictionary<int, string>();

            dictFruits.Add(1, "Mangoes");
            dictFruits.Add(2, "Banana");
            dictFruits.Add(3, "Orange");
            dictFruits.Add(4, "Grapes");

            // Read the value

            string fruit1 = dictFruits[1];
            string fruit2 = dictFruits[2];
            string fruit3 = dictFruits[3];
            string fruit4 = dictFruits[4];


            // update

            dictFruits[4] = "Pineapple";

            dictFruits.Remove(2);

            foreach (KeyValuePair<int,string> fruit in dictFruits)
            {
                Console.WriteLine("Key is " + fruit.Key + " Value is " + fruit.Value);
            }

            foreach (int key in dictFruits.Keys)
            {
                Console.WriteLine("Key = " + key);
            }


            foreach (string value in dictFruits.Values)
            {
                Console.WriteLine("Value = " + value);
            }

            dictFruits.Clear();

        }

        public void StackOperation() // LIFO
        {
            Stack<string> stackFruit = new Stack<string>();

            stackFruit.Push("Mangoes");
            stackFruit.Push("Orange");
            stackFruit.Push("Banana");
            stackFruit.Push("Grapes");
            stackFruit.Push("Pappaya");

            // peek 

            string value1 = stackFruit.Peek();
            string value2 = stackFruit.Peek();
            string value3 = stackFruit.Peek();

            //pop return value and delete it.

            string fruit1 = stackFruit.Pop();
            string fruit2 = stackFruit.Pop();
            string fruit3 = stackFruit.Pop();
            string fruit4 = stackFruit.Pop();
            string fruit5 = stackFruit.Pop();
        }

        public void QueueOperation() // FIFO
        {
            Queue<string> queueFruits = new Queue<string>();

            queueFruits.Enqueue("Mangoes");
            queueFruits.Enqueue("Oranges");
            queueFruits.Enqueue("Banana");
            queueFruits.Enqueue("Grapes");
            queueFruits.Enqueue("Papaya");


            // Dequeue it will return value and delete it.

            string fruit1 = queueFruits.Dequeue();
            string fruit2 = queueFruits.Dequeue();
            string fruit3 = queueFruits.Dequeue();
            string fruit4 = queueFruits.Dequeue();

            // Peek 

            string value1 = queueFruits.Peek();
            string value2 = queueFruits.Peek();
            string value3 = queueFruits.Peek();
            string value4 = queueFruits.Peek();
            string value5 = queueFruits.Peek();
        }
    }
}
