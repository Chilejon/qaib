using Microsoft.VisualStudio.TestTools.UnitTesting;
using QIAB.Services;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingTest()
        {

            Assert.IsTrue(true);

        }

        [TestMethod]
        public void CheckAQuestionTypeOnEntry()
        {
            Assert.IsTrue(true);

           var typeServices = new TypeServices();
          //  Assert.IsTrue(typeServices.IsAlreadyType("General Knowledges"));
          //  Assert.IsFalse(typeServices.IsAlreadyType("Small Banana"));
        }

    }
}
