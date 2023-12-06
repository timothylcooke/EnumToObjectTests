using NUnit.Framework;
using System;

namespace EnumToObjectTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestEnumToObject()
        {
            try
            {
                Assert.Fail($"Enum.ToObject(typeof(MyFlags), 3.0) returned {Enum.ToObject(typeof(MyFlags), 3.0)}. It should have thrown an ArgumentException.");
            }
            catch (ArgumentException) { }
        }
    }

    public enum MyFlags
    {
        A = 1,
        B = 2
    }
}
