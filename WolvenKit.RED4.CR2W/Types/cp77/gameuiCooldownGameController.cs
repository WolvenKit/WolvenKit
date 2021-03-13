using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCooldownGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("maxCooldowns")] public CInt32 MaxCooldowns { get; set; }
		[Ordinal(3)] [RED("cooldownContainer")] public inkCompoundWidgetReference CooldownContainer { get; set; }
		[Ordinal(4)] [RED("poolHolder")] public inkCompoundWidgetReference PoolHolder { get; set; }
		[Ordinal(5)] [RED("mode")] public CEnum<ECooldownGameControllerMode> Mode { get; set; }
		[Ordinal(6)] [RED("effectTypes")] public CArray<CEnum<gamedataStatusEffectType>> EffectTypes { get; set; }
		[Ordinal(7)] [RED("cooldownPool")] public CArray<CHandle<SingleCooldownManager>> CooldownPool { get; set; }
		[Ordinal(8)] [RED("matchBuffer")] public CArray<CHandle<SingleCooldownManager>> MatchBuffer { get; set; }
		[Ordinal(9)] [RED("buffsCallback")] public CUInt32 BuffsCallback { get; set; }
		[Ordinal(10)] [RED("debuffsCallback")] public CUInt32 DebuffsCallback { get; set; }
		[Ordinal(11)] [RED("blackboardDef")] public CHandle<UI_PlayerBioMonitorDef> BlackboardDef { get; set; }
		[Ordinal(12)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }

		public gameuiCooldownGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
