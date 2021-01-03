using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CharacterLevelUpGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(2)]  [RED("data")] public CHandle<LevelUpUserData> Data { get; set; }
		[Ordinal(3)]  [RED("proficencyLabel")] public inkTextWidgetReference ProficencyLabel { get; set; }
		[Ordinal(4)]  [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }
		[Ordinal(5)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public CharacterLevelUpGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
