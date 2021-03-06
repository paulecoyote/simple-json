﻿namespace SimpleJsonTests
{

#if NUNIT
    using TestClass = NUnit.Framework.TestFixtureAttribute;
    using TestMethod = NUnit.Framework.TestAttribute;
    using TestCleanup = NUnit.Framework.TearDownAttribute;
    using TestInitialize = NUnit.Framework.SetUpAttribute;
    using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
    using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;
    using NUnit.Framework;
#else
    using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

    using SimpleJson;

    [TestClass]
    public class EscapeToJavascriptStringTests
    {
        [TestMethod]
        public void BackSlash()
        {
            var serialized = SimpleJson.SerializeObject("c:\\haha.pl");
            var result = SimpleJson.EscapeToJavascriptString(serialized);

            Assert.AreEqual("\"c:\\haha.pl\"", result);
        }

        [TestMethod]
        public void BackSlashWithT()
        {
            var serialized = SimpleJson.SerializeObject("c:\\taha.pl");
            var result = SimpleJson.EscapeToJavascriptString(serialized);

            Assert.AreEqual("\"c:\\taha.pl\"", result);
        }
    }
}