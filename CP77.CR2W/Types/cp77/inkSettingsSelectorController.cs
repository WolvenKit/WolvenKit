using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("IsPreGame")] public CBool IsPreGame { get; set; }
		[Ordinal(1)]  [RED("LabelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(2)]  [RED("ModifiedFlag")] public inkTextWidgetReference ModifiedFlag { get; set; }
		[Ordinal(3)]  [RED("Raycaster")] public inkWidgetReference Raycaster { get; set; }
		[Ordinal(4)]  [RED("SettingsEntry")] public wCHandle<userSettingsVar> SettingsEntry { get; set; }
		[Ordinal(5)]  [RED("additionalText")] public CName AdditionalText { get; set; }
		[Ordinal(6)]  [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(7)]  [RED("hoverGeneralHighlight")] public inkWidgetReference HoverGeneralHighlight { get; set; }
		[Ordinal(8)]  [RED("hoverInAnim")] public CHandle<inkanimProxy> HoverInAnim { get; set; }
		[Ordinal(9)]  [RED("hoverOutAnim")] public CHandle<inkanimProxy> HoverOutAnim { get; set; }
		[Ordinal(10)]  [RED("hoveredChildren")] public CArray<wCHandle<inkWidget>> HoveredChildren { get; set; }
		[Ordinal(11)]  [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(12)]  [RED("varGroupPath")] public CName VarGroupPath { get; set; }
		[Ordinal(13)]  [RED("varName")] public CName VarName { get; set; }

		public inkSettingsSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
