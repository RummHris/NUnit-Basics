using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
public class SummatorTests
{
    [Test]
    public void Test_SumTwoNumbers()
    {
        // Arrange
        var nums = new int[] { 1, 2 };

        // Act        
        var sum = Summator.Sum(nums);

        //Asserrt
        Assert.That(sum, Is.EqualTo(3), "Not equal");
    }
}