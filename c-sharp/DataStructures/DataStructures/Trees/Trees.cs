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
      BinaryTree<T> btree = new BinaryTree<T>();
      public Node<T> Root { get; set; }

      public IEnumerable<T> PreOrder ( Node<T> root, List<T> results )
      {

        return PreOrder(root);
        List<T> result = new List<T>();
        PreOrder(root, results);
        return results;
      }

      public IEnumerable<T> PreOrder ( Node<T> root )
      {
        if (root is null) yield break;
        //yield return root.Value;

        foreach(T item in PreOrder(Root.Left))
        {
          yield return item;
        }
        foreach(T item in PreOrder(Root.Right))
        {
           yield return item;
        }

      }

    }
  }
}
