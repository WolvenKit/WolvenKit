using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsCacheEntry : CVariable
	{
		[Ordinal(0)] [RED("tableIndex")] public CUInt32 TableIndex { get; set; }
		[Ordinal(1)] [RED("entryOffset")] public CUInt32 EntryOffset { get; set; }
		[Ordinal(2)] [RED("entrySize")] public CUInt32 EntrySize { get; set; }

		public physicsCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
