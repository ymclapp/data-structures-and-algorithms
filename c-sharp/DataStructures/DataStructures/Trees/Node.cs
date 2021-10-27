using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataStructures.Trees;

namespace DataStructures.Trees
{
  public class Node<T>
  {
    //public Node<int> Root { get; set; }
    //public Node Node { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    //public Node<int> Next { get; set; }

    public T Value { get; set; }

    public Node ( T value )
    {
      this.Value = value;
    }
  }
}
