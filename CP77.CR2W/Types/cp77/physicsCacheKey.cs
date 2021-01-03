using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsCacheKey : CVariable
	{
		[Ordinal(0)]  [RED("entryIndex")] public CUInt32 EntryIndex { get; set; }
		[Ordinal(1)]  [RED("key")] public physicsGeometryKey Key { get; set; }

		public physicsCacheKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
