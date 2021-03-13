using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("explosiveSkillChecks")] public CHandle<EngDemoContainer> ExplosiveSkillChecks { get; set; }
		[Ordinal(109)] [RED("explosionDefinition")] public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition { get; set; }
		[Ordinal(110)] [RED("explosiveWithQhacks")] public CBool ExplosiveWithQhacks { get; set; }
		[Ordinal(111)] [RED("HealthDecay")] public CFloat HealthDecay { get; set; }
		[Ordinal(112)] [RED("timeToMeshSwap")] public CFloat TimeToMeshSwap { get; set; }
		[Ordinal(113)] [RED("shouldDistractionHitVFXIgnoreHitPosition")] public CBool ShouldDistractionHitVFXIgnoreHitPosition { get; set; }
		[Ordinal(114)] [RED("canBeDisabledWithQhacks")] public CBool CanBeDisabledWithQhacks { get; set; }
		[Ordinal(115)] [RED("disarmed")] public CBool Disarmed { get; set; }
		[Ordinal(116)] [RED("exploded")] public CBool Exploded { get; set; }
		[Ordinal(117)] [RED("provideExplodeAction")] public CBool ProvideExplodeAction { get; set; }
		[Ordinal(118)] [RED("doExplosiveEngineerLogic")] public CBool DoExplosiveEngineerLogic { get; set; }

		public ExplosiveDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
