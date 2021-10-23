using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
  public class TreesTests
  {
    [Fact]
    public void Empty_tree ( )
    {

      //Arrange
      BinaryTree<int> btree = new BinaryTree<int>();
      //btree.Root = new Node(1);
      //btree.Root.Left = new Node(2);

      //Act
      Node root = btree.Root;

      //Assert
      Assert.Null(root);

    }
  }

  internal class BinaryTree<T>
  {
    internal Node Root { get; set; }
    internal Node Node {get; set; }
  }
}
