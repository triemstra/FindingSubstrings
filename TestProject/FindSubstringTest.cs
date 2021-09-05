using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindingSubstring;

namespace TestProject
{
    [TestClass]
    public class FindSubstringTest
    {
        private readonly ManageStrings _mng;

        public FindSubstringTest()
        {
            _mng = new ManageStrings();
        }

        [TestMethod]
        public void TestFindOK()
        {
            string textToSearch = "Whether the weather be fine, or whether the weather be not";
            string subtext = "weather";

            string result = "13,45";
            string hits = _mng.Find(textToSearch, subtext);

            Assert.AreEqual(result, hits);
        }

        [TestMethod]
        public void TestFindNoHits()
        {
            string textToSearch = "Whether the weather be fine, or whether the weather be not";
            string subtext = "water";

            string result = "";
            string hits = _mng.Find(textToSearch, subtext);

            Assert.AreEqual(result, hits);
        }

        [TestMethod]
        public void TestFindSingleChar()
        {
            string textToSearch = "Whether the weather be fine, or whether the weather be not";
            string subtext = "w";

            string result = "1,13,33,45";
            string hits = _mng.Find(textToSearch, subtext);

            Assert.AreEqual(result, hits);
        }

        [TestMethod]
        public void TestFindSpace()
        {
            string textToSearch = "Whether the weather be fine, or whether the weather be not";
            string subtext = " ";

            string result = "8,12,20,23,29,32,40,44,52,55";
            string hits = _mng.Find(textToSearch, subtext);

            Assert.AreEqual(result, hits);
        }
    }
}
