using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationStatsMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] [RED("attribute_01")] public inkWidgetReference Attribute_01 { get; set; }
		[Ordinal(7)] [RED("attribute_02")] public inkWidgetReference Attribute_02 { get; set; }
		[Ordinal(8)] [RED("attribute_03")] public inkWidgetReference Attribute_03 { get; set; }
		[Ordinal(9)] [RED("attribute_04")] public inkWidgetReference Attribute_04 { get; set; }
		[Ordinal(10)] [RED("attribute_05")] public inkWidgetReference Attribute_05 { get; set; }
		[Ordinal(11)] [RED("pointsLabel")] public inkWidgetReference PointsLabel { get; set; }
		[Ordinal(12)] [RED("tooltipSlot")] public inkWidgetReference TooltipSlot { get; set; }
		[Ordinal(13)] [RED("skillPointLabel")] public inkTextWidgetReference SkillPointLabel { get; set; }
		[Ordinal(14)] [RED("reset")] public inkWidgetReference Reset { get; set; }
		[Ordinal(15)] [RED("nextMenuConfirmation")] public inkWidgetReference NextMenuConfirmation { get; set; }
		[Ordinal(16)] [RED("nextMenukConfirmationLibraryWidget")] public inkWidgetReference NextMenukConfirmationLibraryWidget { get; set; }
		[Ordinal(17)] [RED("ConfirmationConfirmBtn")] public inkWidgetReference ConfirmationConfirmBtn { get; set; }
		[Ordinal(18)] [RED("ConfirmationCloseBtn")] public inkWidgetReference ConfirmationCloseBtn { get; set; }
		[Ordinal(19)] [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(20)] [RED("previousPageBtn")] public inkWidgetReference PreviousPageBtn { get; set; }
		[Ordinal(21)] [RED("navigationButtons")] public inkWidgetReference NavigationButtons { get; set; }
		[Ordinal(22)] [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(23)] [RED("attributesControllers")] public CArray<CHandle<characterCreationStatsAttributeBtn>> AttributesControllers { get; set; }
		[Ordinal(24)] [RED("attributePointsAvailable")] public CInt32 AttributePointsAvailable { get; set; }
		[Ordinal(25)] [RED("startingAttributePoints")] public CInt32 StartingAttributePoints { get; set; }
		[Ordinal(26)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(27)] [RED("toolTipOffset")] public inkMargin ToolTipOffset { get; set; }
		[Ordinal(28)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(29)] [RED("confirmAnimationProxy")] public CHandle<inkanimProxy> ConfirmAnimationProxy { get; set; }
		[Ordinal(30)] [RED("hoverdWidget")] public wCHandle<inkWidget> HoverdWidget { get; set; }

		public CharacterCreationStatsMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
