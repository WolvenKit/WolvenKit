using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsCacheEntry : CVariable
	{
		[Ordinal(0)]  [RED("entryOffset")] public CUInt32 EntryOffset { get; set; }
		[Ordinal(1)]  [RED("entrySize")] public CUInt32 EntrySize { get; set; }
		[Ordinal(2)]  [RED("tableIndex")] public CUInt32 TableIndex { get; set; }

		public physicsCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
