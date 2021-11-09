using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
  public class Trees
  {
    public class BinaryTree<T>
    {
      //BinaryTree<T> btree = new BinaryTree<T>();
      public class Node
      {
        public Node<T> Root { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public T Value { get; set; }
      }

      public Node Root;
      public BinaryTree()
      {
        Root = null;
      }

      public Node ReturnRoot()
      {
        return Root;
      }

//      public IEnumerable<T> PreOrder ( Node<T> root, //List<T> results )
//      {
 //       return PreOrder(root);
 //       List<T> result = new List<T>();
 //       PreOrder(root, results);
//        return results;
 //     }

      public IEnumerable<T> PreOrder ( Node<T> root )
      {
        if (root is null) yield break;
        yield return root.Value;

        foreach(T item in PreOrder(root.Left))
        {
          yield return item;
        }
        foreach(T item in PreOrder(root.Right))
        {
           yield return item;
        }

      }

    }
  }
}
