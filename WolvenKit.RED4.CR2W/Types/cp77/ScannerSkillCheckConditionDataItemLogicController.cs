using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDataItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ConditionDataDescriptionName")] public CName ConditionDataDescriptionName { get; set; }
		[Ordinal(2)] [RED("ParentConditionTextPath")] public inkWidgetPath ParentConditionTextPath { get; set; }
		[Ordinal(3)] [RED("OwnConditionTextPath")] public inkWidgetPath OwnConditionTextPath { get; set; }
		[Ordinal(4)] [RED("ConditionDescriptionListPath")] public inkWidgetPath ConditionDescriptionListPath { get; set; }
		[Ordinal(5)] [RED("ConditionDescriptions")] public CArray<wCHandle<inkWidget>> ConditionDescriptions { get; set; }
		[Ordinal(6)] [RED("ParentConditionText")] public wCHandle<inkTextWidget> ParentConditionText { get; set; }
		[Ordinal(7)] [RED("OwnConditionText")] public wCHandle<inkTextWidget> OwnConditionText { get; set; }
		[Ordinal(8)] [RED("ConditionDescriptionList")] public wCHandle<inkCompoundWidget> ConditionDescriptionList { get; set; }

		public ScannerSkillCheckConditionDataItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
