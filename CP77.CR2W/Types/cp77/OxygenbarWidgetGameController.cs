using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OxygenbarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("oxygenControllerRef")] public inkWidgetReference OxygenControllerRef { get; set; }
		[Ordinal(8)]  [RED("oxygenPercTextPath")] public inkTextWidgetReference OxygenPercTextPath { get; set; }
		[Ordinal(9)]  [RED("oxygenStatusTextPath")] public inkTextWidgetReference OxygenStatusTextPath { get; set; }
		[Ordinal(10)]  [RED("bbPSceneTierEventId")] public CUInt32 BbPSceneTierEventId { get; set; }
		[Ordinal(11)]  [RED("swimmingStateBlackboardId")] public CUInt32 SwimmingStateBlackboardId { get; set; }
		[Ordinal(12)]  [RED("oxygenController")] public wCHandle<NameplateBarLogicController> OxygenController { get; set; }
		[Ordinal(13)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(14)]  [RED("animHideTemp")] public CHandle<inkanimDefinition> AnimHideTemp { get; set; }
		[Ordinal(15)]  [RED("animShortFade")] public CHandle<inkanimDefinition> AnimShortFade { get; set; }
		[Ordinal(16)]  [RED("animLongFade")] public CHandle<inkanimDefinition> AnimLongFade { get; set; }
		[Ordinal(17)]  [RED("animHideOxygenProxy")] public CHandle<inkanimProxy> AnimHideOxygenProxy { get; set; }
		[Ordinal(18)]  [RED("currentOxygen")] public CFloat CurrentOxygen { get; set; }
		[Ordinal(19)]  [RED("sceneTier")] public CEnum<GameplayTier> SceneTier { get; set; }
		[Ordinal(20)]  [RED("currentSwimmingState")] public CEnum<gamePSMSwimming> CurrentSwimmingState { get; set; }
		[Ordinal(21)]  [RED("oxygenListener")] public CHandle<OxygenListener> OxygenListener { get; set; }

		public OxygenbarWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
