using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationVoiceOverSwitcher : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("selectedLabel")] public inkTextWidgetReference SelectedLabel { get; set; }
		[Ordinal(2)] [RED("selectorNextBtn")] public inkWidgetReference SelectorNextBtn { get; set; }
		[Ordinal(3)] [RED("selectorPrevBtn")] public inkWidgetReference SelectorPrevBtn { get; set; }
		[Ordinal(4)] [RED("warningLabel")] public inkTextWidgetReference WarningLabel { get; set; }
		[Ordinal(5)] [RED("isMale")] public CBool IsMale { get; set; }
		[Ordinal(6)] [RED("male")] public CString Male { get; set; }
		[Ordinal(7)] [RED("female")] public CString Female { get; set; }
		[Ordinal(8)] [RED("selectorTexture")] public inkImageWidgetReference SelectorTexture { get; set; }
		[Ordinal(9)] [RED("arrowsTexture")] public inkImageWidgetReference ArrowsTexture { get; set; }
		[Ordinal(10)] [RED("optionSwitchHint")] public inkWidgetReference OptionSwitchHint { get; set; }
		[Ordinal(11)] [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(12)] [RED("selector")] public wCHandle<inkWidget> Selector { get; set; }

		public characterCreationVoiceOverSwitcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
