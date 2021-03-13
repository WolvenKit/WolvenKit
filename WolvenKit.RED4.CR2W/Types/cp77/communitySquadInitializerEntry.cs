using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySquadInitializerEntry : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<communityESquadType> Type { get; set; }
		[Ordinal(1)] [RED("value")] public CName Value { get; set; }

		public communitySquadInitializerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
