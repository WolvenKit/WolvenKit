using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCacheKey : CVariable
	{
		[Ordinal(0)] [RED("key")] public physicsGeometryKey Key { get; set; }
		[Ordinal(1)] [RED("entryIndex")] public CUInt32 EntryIndex { get; set; }

		public physicsCacheKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
