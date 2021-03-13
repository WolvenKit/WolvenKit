using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphColorOption : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("optionLabel")] public inkTextWidgetReference OptionLabel { get; set; }
		[Ordinal(2)] [RED("colorPickerBtn")] public inkWidgetReference ColorPickerBtn { get; set; }
		[Ordinal(3)] [RED("selectorNextBtn")] public inkWidgetReference SelectorNextBtn { get; set; }
		[Ordinal(4)] [RED("selectorPrevBtn")] public inkWidgetReference SelectorPrevBtn { get; set; }
		[Ordinal(5)] [RED("selectorTexture")] public inkImageWidgetReference SelectorTexture { get; set; }
		[Ordinal(6)] [RED("arrowsTexture")] public inkImageWidgetReference ArrowsTexture { get; set; }
		[Ordinal(7)] [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(8)] [RED("colorPickerOption")] public wCHandle<gameuiCharacterCustomizationOption> ColorPickerOption { get; set; }
		[Ordinal(9)] [RED("appearanceInfo")] public wCHandle<gameuiAppearanceInfo> AppearanceInfo { get; set; }
		[Ordinal(10)] [RED("currColorIndex")] public CInt32 CurrColorIndex { get; set; }
		[Ordinal(11)] [RED("selector")] public wCHandle<inkWidget> Selector { get; set; }

		public characterCreationBodyMorphColorOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
