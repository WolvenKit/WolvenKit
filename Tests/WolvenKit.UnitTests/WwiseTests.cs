using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Wwise;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class WwiseTests
    {
        [TestMethod]
        public void WemToOgg()
        {
            var testFile = Path.GetFullPath(Path.Combine("Resources", "552019.wem"));
            var expectedFile = Path.GetFullPath(Path.Combine("Resources", "552019.ogg"));

            using var fs = new FileStream(testFile, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);

            var inBuffer = br.ReadBytes((int)fs.Length);
            var got = Wem.Convert(inBuffer);

            using var wantFs = new FileStream(expectedFile, FileMode.Open, FileAccess.Read);
            using var wantBr = new BinaryReader(wantFs);

            var want = wantBr.ReadBytes((int)wantFs.Length);

            Assert.IsTrue(Enumerable.SequenceEqual(got, want), "converted WEM != OGG");
        }
    }
}
