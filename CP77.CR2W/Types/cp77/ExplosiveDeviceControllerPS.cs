using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(0)]  [RED("HealthDecay")] public CFloat HealthDecay { get; set; }
		[Ordinal(1)]  [RED("canBeDisabledWithQhacks")] public CBool CanBeDisabledWithQhacks { get; set; }
		[Ordinal(2)]  [RED("disarmed")] public CBool Disarmed { get; set; }
		[Ordinal(3)]  [RED("doExplosiveEngineerLogic")] public CBool DoExplosiveEngineerLogic { get; set; }
		[Ordinal(4)]  [RED("exploded")] public CBool Exploded { get; set; }
		[Ordinal(5)]  [RED("explosionDefinition")] public CArray<ExplosiveDeviceResourceDefinition> ExplosionDefinition { get; set; }
		[Ordinal(6)]  [RED("explosiveSkillChecks")] public CHandle<EngDemoContainer> ExplosiveSkillChecks { get; set; }
		[Ordinal(7)]  [RED("explosiveWithQhacks")] public CBool ExplosiveWithQhacks { get; set; }
		[Ordinal(8)]  [RED("provideExplodeAction")] public CBool ProvideExplodeAction { get; set; }
		[Ordinal(9)]  [RED("shouldDistractionHitVFXIgnoreHitPosition")] public CBool ShouldDistractionHitVFXIgnoreHitPosition { get; set; }
		[Ordinal(10)]  [RED("timeToMeshSwap")] public CFloat TimeToMeshSwap { get; set; }

		public ExplosiveDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
