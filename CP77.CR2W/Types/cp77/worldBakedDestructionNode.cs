using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBakedDestructionNode : worldMeshNode
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(2)]  [RED("meshFractured")] public raRef<CMesh> MeshFractured { get; set; }
		[Ordinal(3)]  [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(4)]  [RED("meshFracturedAppearance")] public CName MeshFracturedAppearance { get; set; }
		[Ordinal(5)]  [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(6)]  [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(7)]  [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(8)]  [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(9)]  [RED("contactToDamage")] public CFloat ContactToDamage { get; set; }
		[Ordinal(10)]  [RED("numFrames")] public CFloat NumFrames { get; set; }
		[Ordinal(11)]  [RED("frameRate")] public CFloat FrameRate { get; set; }
		[Ordinal(12)]  [RED("playOnlyOnce")] public CBool PlayOnlyOnce { get; set; }
		[Ordinal(13)]  [RED("restartOnTrigger")] public CBool RestartOnTrigger { get; set; }
		[Ordinal(14)]  [RED("disableCollidersOnTrigger")] public CBool DisableCollidersOnTrigger { get; set; }
		[Ordinal(15)]  [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }
		[Ordinal(16)]  [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(17)]  [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }

		public worldBakedDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
