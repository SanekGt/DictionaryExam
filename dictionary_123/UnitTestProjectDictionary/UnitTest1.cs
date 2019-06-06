using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dictionary_123;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
      

        FreqClass freq = new FreqClass();


        [TestMethod]
        public void TestMethod1()
        {

            Dictionary<string, int> result = freq.FreqCount(@"");

            if (result == null)
                Assert.Fail();

        }


        [TestMethod]
        public void Extension()
        {

            Dictionary<string, int> result = freq.FreqCount(@"c:\temp\bmw.jpg");

            if (result == null)
                Assert.Fail();

        }



    
    }
}
