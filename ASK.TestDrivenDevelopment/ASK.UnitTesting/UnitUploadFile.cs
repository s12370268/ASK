using ASK.TestDrivenDevelopment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ASK.UnitTesting
{
    [TestClass]
    public class UnitUploadFile
    {
        [TestMethod]
        public void UploadFile()
        {
            //TODO: 使用 MOCK 假造一個 IFormFile 並且使用 FileUploadHelper 儲存到自訂的指定路徑中

            //NOTE:建議可以這樣使用 Assert.IsTrue(FileUploadHelper.Save(file,@"D://Test/File/test.pdf"));
        }
    }
}
