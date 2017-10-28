using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrepConsole
{
    class Program
    {
        static Dictionary<int, string> GlobalDictionary;

        static void Main(string[] args)
        {
            //ARRAY
            int[] myArray = new int[10];


            //LIST
            /*
                    - Add():    adds an object to the end of the list
                    - Clear():  removes ALL elments from the list
                    - Contains():   checks if an element exists in the list
                    - Remove():     removes first occurance of an object in the list
                    - RemoveAt():   removes element at a specific index
                    - Sort():   sorts elements

             */
            List<int> myList = new List<int>();


            //QUEUE
            /*
                    - Clear():  removes ALL objects from queue
                    - Clone():  creates a shallow copy of the queue
                    - Contains()
                    - Dequeue():   removes AND returns the object at the beginning of the queue (first in line)
                    - Enqueue():   adds object to the END of the queue (back of the line)
             */
            Queue<string> myQueue = new Queue<string>();


            //STACK
            /*
                    - Clear():  removes ALL objects from the stack
                    - Contains():  
                    - Peek():   returns the object at the top of the stack WITHOUT removing it
                    - Pop():    Removes and returns the object at the top of the stack
                    - Push():   inserts an object at the top of the stack
             */
            Stack<double> myStack = new Stack<double>();


            //DICTIONARY
            /*
                    - Add(Key, Value):  adds the specified key and value
                    - Clear():  clears ALL keys and values
                    - ContainsKey():
                    - ContainsValue():
                    - Remove(Key):  
             */
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();


            //USING GLOBAL DICTIONARY
            GlobalDictionary.Add(1, "Gabriel");
        }
    }
}
