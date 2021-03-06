namespace SimpleJsonTests.DataContractTests
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
    public class PrivateGetterSettersSerializeTests
    {
        private DataContractPrivateGetterSetters _dataContractPrivateGetterSetters;

        public PrivateGetterSettersSerializeTests()
        {
            _dataContractPrivateGetterSetters = new DataContractPrivateGetterSetters();
        }

        [TestMethod]
        public void SerializesCorrectly()
        {
            var result = SimpleJson.SerializeObject(_dataContractPrivateGetterSetters,
                                                    SimpleJson.DataContractJsonSerializerStrategy);

            Assert.AreEqual("{\"DataMemberWithoutName\":\"dmv\",\"name\":\"dmnv\"}", result);
        }
    }
}