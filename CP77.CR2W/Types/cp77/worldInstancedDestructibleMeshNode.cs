using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInstancedDestructibleMeshNode : worldMeshNode
	{
		[Ordinal(1000)] [RED("staticMesh")] public raRef<CMesh> StaticMesh { get; set; }
		[Ordinal(1001)] [RED("staticMeshAppearance")] public CName StaticMeshAppearance { get; set; }
		[Ordinal(1002)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(1003)] [RED("filterDataSource")] public CEnum<physicsFilterDataSource> FilterDataSource { get; set; }
		[Ordinal(1004)] [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(1005)] [RED("turnDynamicOnImpulse")] public CBool TurnDynamicOnImpulse { get; set; }
		[Ordinal(1006)] [RED("useAggregate")] public CBool UseAggregate { get; set; }
		[Ordinal(1007)] [RED("enableSelfCollisionInAggregate")] public CBool EnableSelfCollisionInAggregate { get; set; }
		[Ordinal(1008)] [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(1009)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1010)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(1011)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(1012)] [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(1013)] [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(1014)] [RED("fracturingEffect")] public raRef<worldEffect> FracturingEffect { get; set; }
		[Ordinal(1015)] [RED("idleEffect")] public raRef<worldEffect> IdleEffect { get; set; }
		[Ordinal(1016)] [RED("instanceTransforms")] public CArray<Transform> InstanceTransforms { get; set; }
		[Ordinal(1017)] [RED("cookedInstanceTransforms")] public worldTransformBuffer CookedInstanceTransforms { get; set; }
		[Ordinal(1018)] [RED("isPierceable")] public CBool IsPierceable { get; set; }
		[Ordinal(1019)] [RED("isWorkspot")] public CBool IsWorkspot { get; set; }
		[Ordinal(1020)] [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(1021)] [RED("useMeshNavmeshSettings")] public CBool UseMeshNavmeshSettings { get; set; }

		public worldInstancedDestructibleMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
