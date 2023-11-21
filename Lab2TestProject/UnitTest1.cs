namespace Lab2TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateDistanceToOrigin()
        {
            MyClass myClass = new MyClass();

            Assert.AreEqual(myClass.DistanceToOrigin(5, 1), 5, 0990195135927845);
            Assert.AreEqual(myClass.DistanceToOrigin(4, 8), 8, 94427190999916);
            Assert.AreEqual(myClass.DistanceToOrigin(2, 6), 6, 324555320336759);
            Assert.AreEqual(myClass.DistanceToOrigin(3, 7), 7, 615773105863909);
            Assert.AreEqual(myClass.DistanceToOrigin(8, 3), 8,54400374531753);

        }
    }
}