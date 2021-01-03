using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MinotaurMechComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("currentScanAnimation")] public CName CurrentScanAnimation { get; set; }
		[Ordinal(1)]  [RED("currentScanType")] public CEnum<MechanicalScanType> CurrentScanType { get; set; }
		[Ordinal(2)]  [RED("deathAttackRecordID")] public TweakDBID DeathAttackRecordID { get; set; }
		[Ordinal(3)]  [RED("npcCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcCollisionComponent { get; set; }
		[Ordinal(4)]  [RED("npcDeathCollisionComponent")] public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent { get; set; }
		[Ordinal(5)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(6)]  [RED("statusEffectListener")] public CHandle<MinotaurOnStatusEffectAppliedListener> StatusEffectListener { get; set; }

		public MinotaurMechComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
