using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeSystemRevealIdentifier : CVariable
	{
		[Ordinal(0)] [RED("sourceEntityId")] public entEntityID SourceEntityId { get; set; }
		[Ordinal(1)] [RED("reason")] public CName Reason { get; set; }

		public gameVisionModeSystemRevealIdentifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
