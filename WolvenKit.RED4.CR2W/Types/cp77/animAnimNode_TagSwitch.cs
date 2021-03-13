using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TagSwitch : animAnimNode_BaseSwitch
	{
		[Ordinal(16)] [RED("tags")] public CArray<CName> Tags { get; set; }

		public animAnimNode_TagSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
