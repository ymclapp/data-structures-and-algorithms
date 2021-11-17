using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
  public class TreeIntersection
  {
    //https://stackoverflow.com/questions/45718552/is-it-possible-to-add-the-nodes-of-binary-search-tree-to-a-hashset-or-hashmap
    public bool findTarget ( TreeNode root, int k )
    {
      if (root == null)
      {
        throw new NullPointerException();
      }
      HashSet<Integer> set = new HashSet<Integer>();
      return traverse(root, k, set);
    }

    // Traverses across the BST, in order, adding elements to the set
    bool traverse ( Node<T> node, int k, HashSet<Node<T>> set )
    {
      // If the node has a left child, traverse it first
      if (node.left != null)
      {
        return traverse(node.left, k, set);
      }
      // Check to see if the set contains the element that would sum
      // with the node we're checking's element to equal k
      if (set.contains(k - node.element))
      {
        return true;
      }
      // Add node's element to the set
      set.add(node.element);

      // If the node has a right child, traverse it after
      if (node.right != null)
      {
        return traverse(node.right, k, set);
      }
      else
      {
        // No two node's with elements summing k exist in the BST,
        // since you reached the end and found nothing
        return false;
      }
    }
  }
}
