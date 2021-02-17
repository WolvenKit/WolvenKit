using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBakedDestructionNode : worldMeshNode
	{
		[Ordinal(13)] [RED("meshFractured")] public raRef<CMesh> MeshFractured { get; set; }
		[Ordinal(14)] [RED("meshFracturedAppearance")] public CName MeshFracturedAppearance { get; set; }
		[Ordinal(15)] [RED("numFrames")] public CFloat NumFrames { get; set; }
		[Ordinal(16)] [RED("frameRate")] public CFloat FrameRate { get; set; }
		[Ordinal(17)] [RED("playOnlyOnce")] public CBool PlayOnlyOnce { get; set; }
		[Ordinal(18)] [RED("restartOnTrigger")] public CBool RestartOnTrigger { get; set; }
		[Ordinal(19)] [RED("disableCollidersOnTrigger")] public CBool DisableCollidersOnTrigger { get; set; }
		[Ordinal(20)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(21)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(22)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(23)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(24)] [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(25)] [RED("contactToDamage")] public CFloat ContactToDamage { get; set; }
		[Ordinal(26)] [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(27)] [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(28)] [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(29)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(30)] [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldBakedDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
