using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WolvenKit.Common;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Types;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class OpusToolsTests
    {
        /// <summary>
        /// Builds a minimal in-memory .opusinfo holding one entry per given pack index.
        /// </summary>
        private static OpusInfo CreateOpusInfo(params ushort[] packIndices)
        {
            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);

            bw.Write(new byte[12]);             // Header
            bw.Write((uint)packIndices.Length); // OpusCount
            bw.Write(0u);                       // GroupingObjSize4x

            for (var i = 0; i < packIndices.Length; i++)
            {
                bw.Write((uint)(1000 + i)); // OpusHashes
            }
            foreach (var packIndex in packIndices)
            {
                bw.Write(packIndex); // PackIndices
            }
            for (var i = 0; i < packIndices.Length; i++)
            {
                bw.Write(0u); // OpusOffsets
            }
            for (var i = 0; i < packIndices.Length; i++)
            {
                bw.Write((ushort)0); // RiffOpusOffsets
            }
            for (var i = 0; i < packIndices.Length; i++)
            {
                bw.Write(0u); // OpusStreamLengths
            }
            for (var i = 0; i < packIndices.Length; i++)
            {
                bw.Write(0u); // WavStreamLengths
            }
            // no grouping objects

            ms.Position = 0;
            return new OpusInfo(ms);
        }

        /// <summary>
        /// An archive manager that finds no paks, but records every path it was asked for.
        /// </summary>
        private static (IArchiveManager, List<string>) CreateArchiveManager()
        {
            var requested = new List<string>();
            var archiveManager = new Mock<IArchiveManager>();

            archiveManager
                .Setup(x => x.GetGameFile(It.IsAny<ResourcePath>(), It.IsAny<bool>(), It.IsAny<bool>()))
                .Callback((ResourcePath path, bool _, bool _) => requested.Add(path.GetResolvedText() ?? string.Empty))
                .Returns((Core.Interfaces.IGameFile?)null);

            return (archiveManager.Object, requested);
        }

        private static List<double> ExportAll(OpusInfo info, IArchiveManager archiveManager) =>
            OpusTools.ExportAllOpus(info, archiveManager, false, false, new DirectoryInfo(Path.GetTempPath())).ToList();

        [TestMethod]
        public void ExportAllOpus_RequestsEveryPakIncludingTheLast()
        {
            var (archiveManager, requested) = CreateArchiveManager();

            _ = ExportAll(CreateOpusInfo(0, 1, 2, 3), archiveManager);

            CollectionAssert.AreEqual(
                Enumerable.Range(0, 4)
                    .Select(i => @$"base\sound\soundbanks\sfx_container_{i}.opuspak")
                    .ToList(),
                requested);
        }

        [TestMethod]
        public void ExportAllOpus_UsesHighestPackIndexWhenNotSorted()
        {
            // PackIndices are not guaranteed to be ordered, the highest one still has to be exported
            var (archiveManager, requested) = CreateArchiveManager();

            _ = ExportAll(CreateOpusInfo(2, 0, 1), archiveManager);

            CollectionAssert.Contains(requested, @"base\sound\soundbanks\sfx_container_2.opuspak");
        }

        [TestMethod]
        public void ExportAllOpus_ReportsProgressUpToOne()
        {
            var (archiveManager, _) = CreateArchiveManager();

            var progress = ExportAll(CreateOpusInfo(0, 1, 2, 3), archiveManager);

            Assert.AreEqual(4, progress.Count);
            Assert.AreEqual(1.0, progress.Last());
        }
    }
}
