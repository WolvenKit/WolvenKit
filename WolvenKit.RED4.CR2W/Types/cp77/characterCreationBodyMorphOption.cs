using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOption : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("optionLabel")] public inkTextWidgetReference OptionLabel { get; set; }
		[Ordinal(2)] [RED("selectedLabel")] public inkTextWidgetReference SelectedLabel { get; set; }
		[Ordinal(3)] [RED("selectorNextBtn")] public inkWidgetReference SelectorNextBtn { get; set; }
		[Ordinal(4)] [RED("selectorPrevBtn")] public inkWidgetReference SelectorPrevBtn { get; set; }
		[Ordinal(5)] [RED("selectorTexture")] public inkImageWidgetReference SelectorTexture { get; set; }
		[Ordinal(6)] [RED("arrowsTexture")] public inkImageWidgetReference ArrowsTexture { get; set; }
		[Ordinal(7)] [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(8)] [RED("selectorOption")] public wCHandle<gameuiCharacterCustomizationOption> SelectorOption { get; set; }
		[Ordinal(9)] [RED("morphInfo")] public wCHandle<gameuiMorphInfo> MorphInfo { get; set; }
		[Ordinal(10)] [RED("appearanceInfo")] public wCHandle<gameuiAppearanceInfo> AppearanceInfo { get; set; }
		[Ordinal(11)] [RED("switcherInfo")] public wCHandle<gameuiSwitcherInfo> SwitcherInfo { get; set; }
		[Ordinal(12)] [RED("currSelectorIndex")] public CInt32 CurrSelectorIndex { get; set; }
		[Ordinal(13)] [RED("selector")] public wCHandle<inkWidget> Selector { get; set; }
		[Ordinal(14)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public characterCreationBodyMorphOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
