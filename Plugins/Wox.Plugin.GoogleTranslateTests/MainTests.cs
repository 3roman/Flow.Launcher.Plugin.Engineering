using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Wox.Plugin.GoogleTranslate.Tests
{
    [TestClass()]
    public class MainTests
    {
        [TestMethod()]
        public void IsChineseTest()
        {
            var ret = new Main().IsChinese("你好，世界");
            Assert.IsTrue(ret);

            ret = new Main().IsChinese("hello world");
            Assert.IsFalse(ret);
        }
    }
}