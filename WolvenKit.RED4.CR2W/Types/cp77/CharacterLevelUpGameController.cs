using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterLevelUpGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("value")] public inkTextWidgetReference Value { get; set; }
		[Ordinal(10)] [RED("proficencyLabel")] public inkTextWidgetReference ProficencyLabel { get; set; }
		[Ordinal(11)] [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }
		[Ordinal(12)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(13)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(14)] [RED("data")] public CHandle<LevelUpUserData> Data { get; set; }

		public CharacterLevelUpGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
