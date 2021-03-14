using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class stealthAlertGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(10)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(11)] [RED("indicator_01")] public inkImageWidgetReference Indicator_01 { get; set; }
		[Ordinal(12)] [RED("indicator_02")] public inkImageWidgetReference Indicator_02 { get; set; }
		[Ordinal(13)] [RED("indicator_03")] public inkImageWidgetReference Indicator_03 { get; set; }
		[Ordinal(14)] [RED("fluff_01")] public inkWidgetReference Fluff_01 { get; set; }
		[Ordinal(15)] [RED("fluff_02")] public inkWidgetReference Fluff_02 { get; set; }
		[Ordinal(16)] [RED("fluff_03")] public inkWidgetReference Fluff_03 { get; set; }
		[Ordinal(17)] [RED("fluff_04")] public inkWidgetReference Fluff_04 { get; set; }
		[Ordinal(18)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(19)] [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }
		[Ordinal(20)] [RED("playerBlackboardID")] public CUInt32 PlayerBlackboardID { get; set; }
		[Ordinal(21)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(22)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(23)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public stealthAlertGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
