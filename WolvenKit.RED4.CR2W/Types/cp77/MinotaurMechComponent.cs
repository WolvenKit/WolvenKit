using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinotaurMechComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("deathAttackRecordID")] public TweakDBID DeathAttackRecordID { get; set; }
		[Ordinal(6)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(7)] [RED("statusEffectListener")] public CHandle<MinotaurOnStatusEffectAppliedListener> StatusEffectListener { get; set; }
		[Ordinal(8)] [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(9)] [RED("npcDeathCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent { get; set; }
		[Ordinal(10)] [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(11)] [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }

		public MinotaurMechComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
