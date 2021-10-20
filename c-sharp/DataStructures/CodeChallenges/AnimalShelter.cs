using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class AnimalShelter
  {
    public Queue Dog { get; set; }
    public Queue Cat { get; set; }
    public Queue All { get; set; }
    public Node Front { get; set; }
    public Node Tail { get; set; }

    public AnimalShelter()
    {
      Dog = new Queue();
      Cat = new Queue();
      All = new Queue();
    }

    public class Queue
    {
      Node front = null;
      Node rear = null;
      public int count = 0;
    }

    public static Node Front
    {
      get
      {
        return front;
      }
    }

    public Node Rear
    {
      get
      {
        return rear;
      }
    }
    public enum Animal
    {
      qDog = 1,
      qCat = 2
    }
    private class Node
    {
      public Animal Pref { get; set; }
      public Node Next { get; set; }

      public Node(Animal preference)
      {
        this.Pref = preference;
      }
    }
    public void enqueue(Animal animal)
    {
     if (count == 0)
      {
        front = newNode;
      }
     else
      {
        Rear.Next = newNode;
      }
      rear = newNode;
      count++;

    }

    public void dequeue(string Pref)
    {
      //var pref =
      if (Pref = "")
        return null;
    }
    where
    }

  }
}
