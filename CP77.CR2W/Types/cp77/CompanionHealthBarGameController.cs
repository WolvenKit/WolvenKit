using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CompanionHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("healthbar")] public inkWidgetReference Healthbar { get; set; }
		[Ordinal(8)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(9)]  [RED("flatheadListener")] public CUInt32 FlatheadListener { get; set; }
		[Ordinal(10)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(11)]  [RED("maxHealth")] public CFloat MaxHealth { get; set; }
		[Ordinal(12)]  [RED("healthStatListener")] public CHandle<CompanionHealthStatListener> HealthStatListener { get; set; }
		[Ordinal(13)]  [RED("companionBlackboard")] public CHandle<gameIBlackboard> CompanionBlackboard { get; set; }
		[Ordinal(14)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(15)]  [RED("statSystem")] public CHandle<gameStatPoolsSystem> StatSystem { get; set; }

		public CompanionHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
