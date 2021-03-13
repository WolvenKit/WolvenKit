using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadMapItem : CVariable
	{
		[Ordinal(0)] [RED("key")] public wCHandle<gamedataInteractionBase_Record> Key { get; set; }
		[Ordinal(1)] [RED("count")] public CInt32 Count { get; set; }
		[Ordinal(2)] [RED("range")] public CFloat Range { get; set; }

		public SpreadMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
