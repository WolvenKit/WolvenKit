using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotStartedEvent : redEvent
	{
		[Ordinal(0)] [RED("nodeId")] public worldGlobalNodeID NodeId { get; set; }
		[Ordinal(1)] [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(2)] [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }

		public workWorkspotStartedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
