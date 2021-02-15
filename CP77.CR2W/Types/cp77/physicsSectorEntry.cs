using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsSectorEntry : CVariable
	{
		[Ordinal(0)] [RED("sectorBounds")] public Box SectorBounds { get; set; }
		[Ordinal(1)] [RED("sectorHash")] public CUInt64 SectorHash { get; set; }
		[Ordinal(2)] [RED("entryOffset")] public CUInt32 EntryOffset { get; set; }
		[Ordinal(3)] [RED("entrySize")] public CUInt32 EntrySize { get; set; }

		public physicsSectorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
