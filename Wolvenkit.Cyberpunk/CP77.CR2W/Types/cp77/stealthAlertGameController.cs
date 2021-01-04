using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class stealthAlertGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(2)]  [RED("fluff_01")] public inkWidgetReference Fluff_01 { get; set; }
		[Ordinal(3)]  [RED("fluff_02")] public inkWidgetReference Fluff_02 { get; set; }
		[Ordinal(4)]  [RED("fluff_03")] public inkWidgetReference Fluff_03 { get; set; }
		[Ordinal(5)]  [RED("fluff_04")] public inkWidgetReference Fluff_04 { get; set; }
		[Ordinal(6)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(7)]  [RED("indicator_01")] public inkImageWidgetReference Indicator_01 { get; set; }
		[Ordinal(8)]  [RED("indicator_02")] public inkImageWidgetReference Indicator_02 { get; set; }
		[Ordinal(9)]  [RED("indicator_03")] public inkImageWidgetReference Indicator_03 { get; set; }
		[Ordinal(10)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(11)]  [RED("playerBlackboardID")] public CUInt32 PlayerBlackboardID { get; set; }
		[Ordinal(12)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(13)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(14)]  [RED("securityBlackBoardID")] public CUInt32 SecurityBlackBoardID { get; set; }

		public stealthAlertGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
