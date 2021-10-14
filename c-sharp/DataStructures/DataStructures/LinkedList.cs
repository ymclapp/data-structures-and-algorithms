using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    //private static readonly LinkedList list = new LinkedList();
    public Node Head { get; set; }  //used light bulb in the tests to create this

    public void Insert(int value)  //used the light bulb in the tests to create this
    {
      Node newNode = new Node();  //created linkedList empty
      newNode.Value = value;  //told it to insert what it is told - needed this for the second test
      newNode.Next = Head;  //makes the next of the new Node as the Head when inserting at the beginning
      Head = newNode;  //we are drawing the arrow from the Head to the newNode.  we are pointing it to the newNode. Head is a reference to the first node.  Need this for every new Linked List
      //newNode.Next = newNode;
      //throw new NotImplementedException();  //commented out so that the insert would work with out throwing this exception
    }//end of Insert()

    public bool Includes (int valueToFind)
    {
      
      Node currentNode = Head;  //this is a placeholder or reference point so we hold onto Head
      while (currentNode != null)
      {
        if (currentNode.Value == valueToFind)  //while we aren't at the end AND the value in the node we are in is not what we are looking for....
        {
          return true;  //...traverse the nodes and search for the valueToFind
        }
        currentNode = currentNode.Next;
      }
        return false;  //if it does find the valueToFind in the LinkedList, then return true
    }//end of Includes()

    public override String ToString()
    {
      String Out = "";
      Node currentNode = Head;
      while (currentNode != null)
      {
        Out += currentNode.Value;
        Out += " -> ";
        currentNode = currentNode.Next;
      }
      Out += "NULL";
        return Out;
        //Console.WriteLine(currentNode.Value);
        //currentNode = currentNode.Next;
    }//end of the Print()
    public void AtEnd(int appendValue)
    {
      Node newNode = new Node();  //created linkedList empty
      newNode.Value = appendValue;  //
      newNode.Next = null;  //
      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        Node temp = new Node();
        temp = Head;
        while (temp.Next != null)
          temp = temp.Next;
        temp.Next = newNode;
      }
    }//end of AtEnd()

    public void AddAtHead(int oldHead, int addHead)
    {
      if(Head.Value == oldHead)
      {
        Insert(addHead);
        return;
      }

      Node newNode = new Node();//created linkedlist empty
      //newNode.Value = addHead;
      // newNode.Next = null
      Node currentNode = Head;

      while(currentNode != null)
      {
        if(currentNode.Next.Value == oldHead)
        {
          newNode.Next = currentNode.Next;
          currentNode.Next = newNode;
          return;
          //currentNode.Next = newNode;
        }
        currentNode = currentNode.Next;
      }

    }


    public void AddAfter(int searchValue, int addValue)
    {
      Node newNode = new Node();//addValue?
      Node currentNode = Head;

      while(currentNode != null)
      {
        if (currentNode.Value == searchValue)
        {
          //Node newNode = new Node();
          newNode.Next = currentNode.Next;
          currentNode.Next = newNode;
          return;
        }
        currentNode = currentNode.Next;
      }
    }//end of AddBefore()

    public int KthValue(int searchValue)
    {
      int llLength = 0;
      Node currentNode = Head;

      while(currentNode != null)
      {
        llLength++;
        currentNode = currentNode.Next;
      }

      if (searchValue < 0)
      {
        throw new IndexOutOfRangeException("Enter a positive value");
      }

      if(searchValue > llLength)
      {
        throw new IndexOutOfRangeException("Enter a value that is in the current list");
      }

      currentNode = Head;
      int counter = 0;
      while(currentNode != null && counter < llLength - searchValue -1)
      {
        counter++;
        currentNode = currentNode.Next;
      }
      return currentNode.Value;
    }//end of KthValue()
  }//end of class LinkedList
}//end of namespace DataStructures
