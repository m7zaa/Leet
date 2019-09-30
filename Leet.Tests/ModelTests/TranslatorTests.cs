using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leet;
namespace Leet.Tests
{
    [TestClass]
    public class TranslatorTest
    {
        [TestMethod]
        public void TranslateETo3_LetterEBecomesNumeral3_p3n()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("p3n", testLeetTranslator.TranslateETo3("pEn"));
        }
    }
}