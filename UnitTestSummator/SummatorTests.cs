using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
    public class UnitTest1
    {
        [Test]
        public void Test_SumTwoNumbers()
        {
            var sum = Summator.Sum(new int[] { 1, 2 });
            Assert.AreEqual(3, sum);
        }
    }
}
