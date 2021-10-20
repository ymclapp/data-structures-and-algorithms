using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
  public class AnimalShelterTests
  {
    [Fact]
    public void New_empty_queues()
    {

      //Arrange
      //Queue<string> Dog = Queue<string>();
      //Queue<string> Cat = Queue<string>();
      var qDog = new Queue<string>();
      var qCat = new Queue<string>();

      //Act
      bool result1 = qDog.Count == 0;
      bool result2 = qCat.Count == 0;

      //Assert
      Assert.True(result1);
      Assert.True(result2);


    }

    public Queue<T> Queue<T>()
    {
      throw new NotImplementedException();
    }
  }
}
