using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
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
            Assert.AreEqual("p3n", testLeetTranslator.TranslateLetter("pEn"));
        }
        [TestMethod]
        public void TranslateOTo0_LetterOBecomesNumeral0_p0d()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("p0d", testLeetTranslator.TranslateLetter("pOd"));
        }
        [TestMethod]
        public void TranslateTTo7_LetterTBecomesNumeral7_7h3()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("7h3", testLeetTranslator.TranslateLetter("the"));
        }
        [TestMethod]
        public void TranslateITo1_LetterIBecomesNumeral1_1sle()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("1zl3", testLeetTranslator.TranslateLetter("Isle"));
        }
        [TestMethod]
        public void TranslateSToZ_LetterSBecomesLetterZ_snackz()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("snackz", testLeetTranslator.TranslateLetter("snacks"));
        }
        [TestMethod]
        public void TranslatePhraseToStrings_LetterSBecomesLetterZ_The_Apple()
        {
            LeetTranslator testLeetTranslator = new LeetTranslator();
            Assert.AreEqual("7h3 snappl3z ", testLeetTranslator.SplitPhraseToWords("The snapples"));
        }

    }
}