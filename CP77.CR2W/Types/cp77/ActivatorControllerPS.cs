using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivatorControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("hasSpiderbotInteraction")] public CBool HasSpiderbotInteraction { get; set; }
		[Ordinal(105)] [RED("spiderbotInteractionLocationOverride")] public NodeRef SpiderbotInteractionLocationOverride { get; set; }
		[Ordinal(106)] [RED("hasSimpleInteraction")] public CBool HasSimpleInteraction { get; set; }
		[Ordinal(107)] [RED("alternativeInteractionName")] public TweakDBID AlternativeInteractionName { get; set; }
		[Ordinal(108)] [RED("alternativeSpiderbotInteractionName")] public TweakDBID AlternativeSpiderbotInteractionName { get; set; }
		[Ordinal(109)] [RED("alternativeQuickHackName")] public TweakDBID AlternativeQuickHackName { get; set; }
		[Ordinal(110)] [RED("activatorSkillChecks")] public CHandle<GenericContainer> ActivatorSkillChecks { get; set; }
		[Ordinal(111)] [RED("alternativeInteractionString")] public CString AlternativeInteractionString { get; set; }

		public ActivatorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
