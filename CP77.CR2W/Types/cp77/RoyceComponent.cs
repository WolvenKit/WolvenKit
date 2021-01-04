using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RoyceComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("healthListener")] public CHandle<RoyceHealthChangeListener> HealthListener { get; set; }
		[Ordinal(1)]  [RED("hitData")] public CHandle<animAnimFeature_HitReactionsData> HitData { get; set; }
		[Ordinal(2)]  [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(3)]  [RED("npcHitRepresentationComponent")] public CHandle<entIComponent> NpcHitRepresentationComponent { get; set; }
		[Ordinal(4)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(5)]  [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(6)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public RoyceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
