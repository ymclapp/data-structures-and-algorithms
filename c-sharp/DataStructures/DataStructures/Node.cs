using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class Node
  {
    public Node(int addValue1)
    {
    }

    public int Value { get; set; }  //holds the value that we are inserting in the node
    public Node Next { get; set; }
    public Node Head { get; set; }
    public Node underTop { get; set; }

    //public Node addValue { get; set; }
  }
}
