using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLib11Test
{
    class StringFunctionsTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_CountCharacters()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            int result = sf.CountCharacters("Hello World");
            Assert.AreEqual(11, result);
        }

        [Test]
        public void Test_IsPalindrome()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            bool result = sf.IsPalindrome("madam");
            Assert.IsTrue(result);
            result = sf.IsPalindrome("manav");
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_ReverseSentence()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            string result = sf.ReverseSentence("this is a book");
            Assert.AreEqual("koob a si siht", result);
        }
        [Test]
        public void Test_CountDetails()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            sf.CountDetails("Hello World 123!", out int vowels, out int consonants, out int digits, out int specials);
            Assert.AreEqual(3, vowels);
            Assert.AreEqual(7, consonants);
            Assert.AreEqual(3, digits);
            Assert.AreEqual(1, specials);
        }

        [Test]
        public void Test_ToProperCase()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            string result = sf.ToProperCase("hello world");
            Assert.AreEqual("Hello World", result);
        }

        [Test]
        public void test_CombineWith()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            string result = sf.CombineWith("Hello", "World");
            Assert.AreEqual("Hello World", result);
        }

        [Test]
        public void Test_RemoveExtraSpaces()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            string result = sf.RemoveExtraSpaces("Hello   World");
            Assert.AreEqual("Hello World", result);
        }
        [Test]
        public void Test_WordCount()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            int result = sf.WordCount("Hello World");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_ContainsSubstring()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            bool result = sf.ContainsSubstring("Hello World", "World");
            Assert.IsTrue(result);
            result = sf.ContainsSubstring("Hello World", "world");
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_SubstringOccurrences()
        {
            ClassLib11.StringFunctions sf = new ClassLib11.StringFunctions();
            int result = sf.SubstringOccurrences("Hello World Hello", "Hello");
            Assert.AreEqual(2, result);
            result = sf.SubstringOccurrences("Hello World Hello", "world");
            Assert.AreEqual(0, result);
        }
    }
}
