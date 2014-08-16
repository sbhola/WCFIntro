using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcFictures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToCreateComplexNumber()
        {
            using (var client = new CalcService.CalcServiceClient())
            {
                var compObj = client.CreateComplexNumber(10, 20);
                Assert.AreEqual(10, client.GetRealPart(compObj));
                Assert.AreEqual(20, client.GetImagPart(compObj));
            }
            
        }
    }
}
