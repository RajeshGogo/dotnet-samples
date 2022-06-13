using DriveV2Snippets;
using NUnit.Framework;

namespace DriveV2SnippetsTest;

public class UploadWithConversionTest :  BaseTest
{
    private string filePath = "files/report.csv"; 
    [Test]
        public void TestUploadWithConversion()
        {
            var id = UploadWithConversion.DriveUploadWithConversion(filePath);
            Assert.IsNotNull(id);
            DeleteFileOnCleanup(id);
        }

}
