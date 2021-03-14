using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectEvents : LocomotionGroundEvents
	{
		[Ordinal(0)] [RED("statusEffectRecord")] public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord { get; set; }
		[Ordinal(1)] [RED("playerStatusEffectRecordData")] public wCHandle<gamedataStatusEffectPlayerData_Record> PlayerStatusEffectRecordData { get; set; }
		[Ordinal(2)] [RED("animFeatureStatusEffect")] public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect { get; set; }

		public StatusEffectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
