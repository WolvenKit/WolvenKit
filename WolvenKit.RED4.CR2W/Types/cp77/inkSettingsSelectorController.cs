using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("LabelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(2)] [RED("ModifiedFlag")] public inkTextWidgetReference ModifiedFlag { get; set; }
		[Ordinal(3)] [RED("Raycaster")] public inkWidgetReference Raycaster { get; set; }
		[Ordinal(4)] [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(5)] [RED("hoverGeneralHighlight")] public inkWidgetReference HoverGeneralHighlight { get; set; }
		[Ordinal(6)] [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(7)] [RED("SettingsEntry")] public wCHandle<userSettingsVar> SettingsEntry { get; set; }
		[Ordinal(8)] [RED("hoveredChildren")] public CArray<wCHandle<inkWidget>> HoveredChildren { get; set; }
		[Ordinal(9)] [RED("IsPreGame")] public CBool IsPreGame { get; set; }
		[Ordinal(10)] [RED("varGroupPath")] public CName VarGroupPath { get; set; }
		[Ordinal(11)] [RED("varName")] public CName VarName { get; set; }
		[Ordinal(12)] [RED("additionalText")] public CName AdditionalText { get; set; }
		[Ordinal(13)] [RED("hoverInAnim")] public CHandle<inkanimProxy> HoverInAnim { get; set; }
		[Ordinal(14)] [RED("hoverOutAnim")] public CHandle<inkanimProxy> HoverOutAnim { get; set; }

		public inkSettingsSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
