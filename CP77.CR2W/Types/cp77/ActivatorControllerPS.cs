using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatorControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("activatorSkillChecks")] public CHandle<GenericContainer> ActivatorSkillChecks { get; set; }
		[Ordinal(1)]  [RED("alternativeInteractionName")] public TweakDBID AlternativeInteractionName { get; set; }
		[Ordinal(2)]  [RED("alternativeInteractionString")] public CString AlternativeInteractionString { get; set; }
		[Ordinal(3)]  [RED("alternativeQuickHackName")] public TweakDBID AlternativeQuickHackName { get; set; }
		[Ordinal(4)]  [RED("alternativeSpiderbotInteractionName")] public TweakDBID AlternativeSpiderbotInteractionName { get; set; }
		[Ordinal(5)]  [RED("hasSimpleInteraction")] public CBool HasSimpleInteraction { get; set; }
		[Ordinal(6)]  [RED("hasSpiderbotInteraction")] public CBool HasSpiderbotInteraction { get; set; }
		[Ordinal(7)]  [RED("spiderbotInteractionLocationOverride")] public NodeRef SpiderbotInteractionLocationOverride { get; set; }

		public ActivatorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
