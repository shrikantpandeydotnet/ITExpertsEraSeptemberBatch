using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    internal class CollectionsExample
    {

        public void ArrayListOperation()
        {
            // Declare ArrayList 

            ArrayList arrList = new ArrayList();

            // Insert value into ArrayList
            arrList.Add(1);
            arrList.Add("Shivani");
            arrList.Add(DateTime.Now);
            arrList.Add(false);

            // Read from the ArrayList

            int varInt = Convert.ToInt32(arrList[0]);

            string varString = Convert.ToString(arrList[1]);
            DateTime vardatetime = Convert.ToDateTime(arrList[2]);
            bool varBool = Convert.ToBoolean(arrList[3]);

            // Insert in between

            arrList.Insert(1, "Tanushree");

            // Update

            arrList[1] = "Aniket";

            // Remove 

            arrList.Remove(false);
            arrList.RemoveAt(1);

            // Count

            int count = arrList.Count;

           bool isExist =  arrList.Contains(1);
           bool isExist2 =  arrList.Contains(100);

        }

        public void HashTableOperation()
        {
            // Create object

            Hashtable objHash = new Hashtable();

            // Insert into hashtable

            objHash.Add(1, "Shivam");
            objHash.Add("Test", DateTime.Now);
            objHash.Add(3, 40);
            objHash.Add(4, true);

            // Read the value. 


            string valString = Convert.ToString(objHash[1]);
            DateTime valDate= Convert.ToDateTime(objHash["Test"]);
            int valInt = Convert.ToInt32(objHash[3]);
            bool valBool = Convert.ToBoolean(objHash[4]);

            // update 

            objHash["Test"] = "String Test";


            // Remove

            objHash.Remove(3);

           

            // get all keys

            foreach (var item in objHash.Keys)
            {
                Console.WriteLine(item);
            }

            // get all the values 

            foreach (var item in objHash.Values)
            {
                Console.WriteLine(item);

            }

            // Clear Everything

            objHash.Clear();


        }

        public void StackOperation() // LIFO | Last In First Out
        {
            // Create stack 

            Stack objStack = new Stack();

            // insert 

            objStack.Push(1);
            objStack.Push(10);
            objStack.Push(133);
            objStack.Push(444);

            // to get the value. 


           int value1 = Convert.ToInt32( objStack.Pop()); // it will always return last value and delete it as well. 
           int value2 = Convert.ToInt32( objStack.Pop()); // it will always return last value and delete it as well. 

            // if you only want to read and not delete

            int valuPeek = Convert.ToInt32(objStack.Peek());
            int valuPeek2 = Convert.ToInt32(objStack.Peek());
            int valuPeek3 = Convert.ToInt32(objStack.Peek());

            int count = objStack.Count;
            bool valueExist = objStack.Contains(10);
        }

        public void QueueOperation() // FIFO | First In First Out
        {
            // Create Queue

            Queue objQueue = new Queue();

            // insert 

            objQueue.Enqueue(10);
            objQueue.Enqueue(20);
            objQueue.Enqueue(100);
            objQueue.Enqueue(250);

            // get the value and delete

            int value1 = Convert.ToInt32( objQueue.Dequeue());
            int value2 = Convert.ToInt32( objQueue.Dequeue());

            // only get the value and not delete it. 

            int value3 = Convert.ToInt32(objQueue.Peek());
            int value4 = Convert.ToInt32(objQueue.Peek());
            int value5 = Convert.ToInt32(objQueue.Peek());


            int count = objQueue.Count;

            objQueue.Clear();



        }
    }
}
