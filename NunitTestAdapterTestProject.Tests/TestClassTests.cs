using System.Collections.Generic;
using NUnit.Framework;
using NunitTestAdapterTestProject;

namespace Tests
{
    public class TestClassTests
    {
        private static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(1, 1, 2).SetArgDisplayNames("1, 1, 2");
            yield return new TestCaseData(2, 3, 5).SetArgDisplayNames("5");
        }
        [Test, TestCaseSource(nameof(TestCases))]
        public void Test1(long n1, long n2, long expected)
        {
            var instance = new TestClass();
            var result = instance.Add(n1, n2);
            Assert.AreEqual(expected, result);
        }
    }
}