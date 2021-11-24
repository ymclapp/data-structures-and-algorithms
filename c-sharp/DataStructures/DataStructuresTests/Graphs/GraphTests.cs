using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructuresTests.Graphs
{
  public class GraphTests
  {
    [Fact]
    public void Empty_Graph ()
    {
      //Arrange
      var graph = new Graph();

      //Act


      //Assert
      Assert.Empty(graph.Nodes);
      Assert.Equal(0, graph.Count);
    }
    [Fact]
    public void Add_A_Node_to_Graph()
    {
      //Arrange
      var graph = new Graph();

      //Act
      GraphNodes result = graph.AddNode("Piper");

      //Assert - we needed five asserts to make sure that it absolutely was correct
      Assert.NotEmpty(graph.Nodes);
      Assert.Equal(1, graph.Count);

      Assert.NotNull(result);
      Assert.Equal("Piper", result.Value);
      Assert.Contains(result, graph.Nodes);

      //Assert.Empty(result.Neighbors);
      //Assert.Empty(graph.GetNeighbors(result));
    }

    [Fact]
    public void Add_Another_Node()
    {
      //Arrange
      var graph = new Graph();

      graph.AddNode("Piper");
      graph.AddNode("Rowdy");

      //Act
      //graph.AddEdge(source, destination);

      //Assert
      //Assert.True(graph.GetNeighbors("Piper").ContainsKey("Rowdy")

    }

  }
}
