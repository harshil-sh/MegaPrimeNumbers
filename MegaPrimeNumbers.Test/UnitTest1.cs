namespace MegaPrimeNumbers.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(new List<int>() { 2, 3, 5, 7 },MegaPrimeNumbers.Program.FetchListOfMegaPrimeNos(10));
        }
        [Test]
        public void Test2() 
        {
            Assert.AreEqual(new List<int>() { 2, 3, 5, 7, 23, 37 }, MegaPrimeNumbers.Program.FetchListOfMegaPrimeNos(37));
        }
    }
}