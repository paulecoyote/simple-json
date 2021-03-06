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
    public class PublicFieldsSerializeTests
    {
        private DataContractPublicFields _dataContractPublicFields;

        public PublicFieldsSerializeTests()
        {
            _dataContractPublicFields = new DataContractPublicFields();
        }

        [TestMethod]
        public void SerializesCorrectly()
        {
            var result = SimpleJson.SerializeObject(_dataContractPublicFields,
                                                    SimpleJson.DataContractJsonSerializerStrategy);

            Assert.AreEqual("{\"DataMemberWithoutName\":\"dmv\",\"name\":\"dmnv\"}", result);
        }
    }
}