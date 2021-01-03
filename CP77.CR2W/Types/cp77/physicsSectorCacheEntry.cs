using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheEntry : CVariable
	{
		[Ordinal(0)]  [RED("entryOffset")] public CUInt32 EntryOffset { get; set; }
		[Ordinal(1)]  [RED("entrySize")] public CUInt32 EntrySize { get; set; }

		public physicsSectorCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
