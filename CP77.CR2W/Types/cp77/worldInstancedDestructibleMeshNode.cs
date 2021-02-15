using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInstancedDestructibleMeshNode : worldMeshNode
	{
		[Ordinal(13)] [RED("staticMesh")] public raRef<CMesh> StaticMesh { get; set; }
		[Ordinal(14)] [RED("staticMeshAppearance")] public CName StaticMeshAppearance { get; set; }
		[Ordinal(15)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(16)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(17)] [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(18)] [RED("turnDynamicOnImpulse")] public CBool TurnDynamicOnImpulse { get; set; }
		[Ordinal(19)] [RED("useAggregate")] public CBool UseAggregate { get; set; }
		[Ordinal(20)] [RED("enableSelfCollisionInAggregate")] public CBool EnableSelfCollisionInAggregate { get; set; }
		[Ordinal(21)] [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(22)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(23)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(24)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(25)] [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(26)] [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(27)] [RED("fracturingEffect")] public raRef<worldEffect> FracturingEffect { get; set; }
		[Ordinal(28)] [RED("idleEffect")] public raRef<worldEffect> IdleEffect { get; set; }
		[Ordinal(29)] [RED("instanceTransforms")] public CArray<Transform> InstanceTransforms { get; set; }
		[Ordinal(30)] [RED("cookedInstanceTransforms")] public worldTransformBuffer CookedInstanceTransforms { get; set; }
		[Ordinal(31)] [RED("isPierceable")] public CBool IsPierceable { get; set; }
		[Ordinal(32)] [RED("isWorkspot")] public CBool IsWorkspot { get; set; }
		[Ordinal(33)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(34)] [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldInstancedDestructibleMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
