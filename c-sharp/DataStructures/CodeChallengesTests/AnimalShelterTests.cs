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

    [Fact]
    public void Enqueuing_into_each_of_the_queues()
    {

      //Arrange
      var qDog = new Queue<string>();
      var qCat = new Queue<string>();

      //Act
      qDog.Enqueue("Dog-Blackie-1");
      qCat.Enqueue("Cat-Tuxedo-1");
      //qDog.Enqueue("Dog-Tex-2");

      //Assert
      Assert.Single(qDog);
      //Assert.Equal(2, qDog.Count);
      Assert.Single(qCat);
    }

    [Fact]
    public void Peeking_into_each_queue()
    {

      //Arrange
      var qDog = new Queue<string>();
      var qCat = new Queue<string>();

      //Act
      qDog.Enqueue("Dog-Blackie-1");
      qCat.Enqueue("Cat-Tuxedo-1");
      qDog.Enqueue("Dog-Tex-2");
      qDog.Enqueue("Dog-Mister-3");
      qCat.Enqueue("Cat-Smokey-2");
      string result1 = (string)qDog.Peek();
      string result2 = (string)qCat.Peek();

      //Arrange
      Assert.Equal("Cat-Tuxedo-1", result2);
      Assert.Equal("Dog-Blackie-1", result1);


    }

    public Queue<T> Queue<T>()
    {
      throw new NotImplementedException();
    }
  }
}
