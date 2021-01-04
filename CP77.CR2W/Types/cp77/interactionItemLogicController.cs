using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interactionItemLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("QHIllegalIndicator")] public inkWidgetReference QHIllegalIndicator { get; set; }
		[Ordinal(1)]  [RED("QuickHackCost")] public inkTextWidgetReference QuickHackCost { get; set; }
		[Ordinal(2)]  [RED("QuickHackCostHolder")] public inkWidgetReference QuickHackCostHolder { get; set; }
		[Ordinal(3)]  [RED("QuickHackHolder")] public inkCompoundWidgetReference QuickHackHolder { get; set; }
		[Ordinal(4)]  [RED("QuickHackIcon")] public inkImageWidgetReference QuickHackIcon { get; set; }
		[Ordinal(5)]  [RED("RootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(6)]  [RED("SCIllegalIndicator")] public inkWidgetReference SCIllegalIndicator { get; set; }
		[Ordinal(7)]  [RED("SkillCheckFailBG")] public inkWidgetReference SkillCheckFailBG { get; set; }
		[Ordinal(8)]  [RED("SkillCheckPassBG")] public inkWidgetReference SkillCheckPassBG { get; set; }
		[Ordinal(9)]  [RED("additionalReqsNeeded")] public inkWidgetReference AdditionalReqsNeeded { get; set; }
		[Ordinal(10)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(11)]  [RED("inActiveTransparency")] public CFloat InActiveTransparency { get; set; }
		[Ordinal(12)]  [RED("inputButtonContainer")] public inkCompoundWidgetReference InputButtonContainer { get; set; }
		[Ordinal(13)]  [RED("inputDisplayController")] public wCHandle<inkInputDisplayController> InputDisplayController { get; set; }
		[Ordinal(14)]  [RED("inputDisplayControllerRef")] public inkWidgetReference InputDisplayControllerRef { get; set; }
		[Ordinal(15)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(16)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(17)]  [RED("labelFail")] public inkTextWidgetReference LabelFail { get; set; }
		[Ordinal(18)]  [RED("skillCheck")] public inkCompoundWidgetReference SkillCheck { get; set; }
		[Ordinal(19)]  [RED("skillCheckIcon")] public inkImageWidgetReference SkillCheckIcon { get; set; }
		[Ordinal(20)]  [RED("skillCheckNormalReqs")] public inkCompoundWidgetReference SkillCheckNormalReqs { get; set; }
		[Ordinal(21)]  [RED("skillCheckText")] public inkTextWidgetReference SkillCheckText { get; set; }

		public interactionItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
