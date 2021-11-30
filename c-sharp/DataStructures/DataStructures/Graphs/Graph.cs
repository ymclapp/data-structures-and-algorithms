using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
  public class Graph
  {
    //add node
    public GraphNodes AddNode ( string value )
    {
      var newNode = new GraphNodes
      {
        Value = value,
      };
      nodes.Add(newNode);

      return newNode;
    }
    //add edge

    //public void AddEdge(GraphNodes source, GraphNodes destination)
   // {
   //   source.AddEdge(destination);
   //   destination.AddEdge(source);
  //  }
    //get nodes

    //Private storage for our nodes
    private List<GraphNodes> nodes = new List<GraphNodes>();

    //Public should not be able to Add directly
    public IEnumerable<GraphNodes> Nodes => nodes;
    //get neighbors
    // size
    public int Count => Nodes.Count();

    public IEnumerable GetNeighbors ( GraphNodes result )
    {
      throw new NotImplementedException();
    }
  }

  public class GraphNodes
  {
  public string Value { get; set; }
    public IEnumerable Neighbors { get; set; }
  }
}
