using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemountingMountingEvent : redEvent
	{
		[Ordinal(0)] [RED("request")] public CHandle<gamemountingMountingRequest> Request { get; set; }
		[Ordinal(1)] [RED("relationship")] public gamemountingMountingRelationship Relationship { get; set; }

		public gamemountingMountingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
