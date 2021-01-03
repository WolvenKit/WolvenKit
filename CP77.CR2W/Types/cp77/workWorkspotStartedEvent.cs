using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workWorkspotStartedEvent : redEvent
	{
		[Ordinal(0)]  [RED("nodeId")] public worldGlobalNodeID NodeId { get; set; }
		[Ordinal(1)]  [RED("statusEffectID")] public TweakDBID StatusEffectID { get; set; }
		[Ordinal(2)]  [RED("tags")] public CArray<CName> Tags { get; set; }

		public workWorkspotStartedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
