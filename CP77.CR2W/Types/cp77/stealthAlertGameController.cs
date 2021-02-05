using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class stealthAlertGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(8)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(9)]  [RED("indicator_01")] public inkImageWidgetReference Indicator_01 { get; set; }
		[Ordinal(10)]  [RED("indicator_02")] public inkImageWidgetReference Indicator_02 { get; set; }
		[Ordinal(11)]  [RED("indicator_03")] public inkImageWidgetReference Indicator_03 { get; set; }
		[Ordinal(12)]  [RED("fluff_01")] public inkWidgetReference Fluff_01 { get; set; }
		[Ordinal(13)]  [RED("fluff_02")] public inkWidgetReference Fluff_02 { get; set; }
		[Ordinal(14)]  [RED("fluff_03")] public inkWidgetReference Fluff_03 { get; set; }
		[Ordinal(15)]  [RED("fluff_04")] public inkWidgetReference Fluff_04 { get; set; }
		[Ordinal(16)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(17)]  [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }
		[Ordinal(18)]  [RED("playerBlackboardID")] public CUInt32 PlayerBlackboardID { get; set; }
		[Ordinal(19)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(20)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(21)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public stealthAlertGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
