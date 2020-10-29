using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordREST.Controllers;

namespace RESTTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RecordsController ctr = new RecordsController();

            var control = ctr.Get(2006);

            Assert.AreEqual(2006, control);
        }
    }
}
