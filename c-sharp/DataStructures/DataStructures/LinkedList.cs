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
      while ((currentNode != null) && (currentNode.Value != valueToFind))  //while we aren't at the end AND the value in the node we are in is not what we are looking for....
      {
        currentNode = currentNode.Next;  //...traverse the nodes and search for the valueToFind

        return false;  //if it does not find the valueToFind anywhere in the LinkedList, then return false
      }
      return true;  //if it does find the valueToFind in the LinkedList, then return true
    }//end of Includes()

    public override String ToString()
    {
      String Out = "";
      Node currentNode = Head;
      while (currentNode != null)
      {
        Out += currentNode.Value;
        Out += "-->";
        currentNode = currentNode.Next;
      }
        return Out;
        //Console.WriteLine(currentNode.Value);
        //currentNode = currentNode.Next;
    }//end of the Print()
  }//end of class LinkedList
}//end of namespace DataStructures
