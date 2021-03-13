using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistractionSetup : CVariable
	{
		[Ordinal(0)] [RED("StimuliRange")] public CFloat StimuliRange { get; set; }
		[Ordinal(1)] [RED("disableOnActivation")] public CBool DisableOnActivation { get; set; }
		[Ordinal(2)] [RED("hasSimpleInteraction")] public CBool HasSimpleInteraction { get; set; }
		[Ordinal(3)] [RED("hasSpiderbotInteraction")] public CBool HasSpiderbotInteraction { get; set; }
		[Ordinal(4)] [RED("hasQuickHack")] public CBool HasQuickHack { get; set; }
		[Ordinal(5)] [RED("hasComputerInteraction")] public CBool HasComputerInteraction { get; set; }
		[Ordinal(6)] [RED("alternativeInteractionName")] public TweakDBID AlternativeInteractionName { get; set; }
		[Ordinal(7)] [RED("alternativeSpiderbotInteractionName")] public TweakDBID AlternativeSpiderbotInteractionName { get; set; }
		[Ordinal(8)] [RED("alternativeQuickHackName")] public TweakDBID AlternativeQuickHackName { get; set; }
		[Ordinal(9)] [RED("skillChecks")] public CHandle<EngDemoContainer> SkillChecks { get; set; }
		[Ordinal(10)] [RED("explosionDefinition")] public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition { get; set; }

		public DistractionSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
