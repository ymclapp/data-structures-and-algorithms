using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  class PseudoQueue
  {
    public Stack<int> qstack1 = new Stack<int>();
    public Stack<int> qstack2 = new Stack<int>();

    public void enqueue(int value)
    {
      while(qstack1.Count > 0)
      {
        qstack2.Push(qstack1.Pop());
      }
      qstack1.Push(value);

      while (qstack2.Count > 0)
      {
        qstack1.Push(qstack2.Pop());
      }
    }

    public int dequeue()
    {
      if(qstack1.Count == 0)
      {
        Console.WriteLine("Stop - the queue is empty");
        return 0;
      }

      int value = (int)qstack1.Peek();
      qstack1.Pop();
      return value;
    }
    //class LinkedListNode
    //{
//
    //}
    //public class 
    //private readonly int size;
    //public int Size { get { return size; } }
  }

}
