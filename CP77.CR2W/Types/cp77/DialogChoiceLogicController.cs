using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DialogChoiceLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("InputViewRef")] public inkWidgetReference InputViewRef { get; set; }
		[Ordinal(1)]  [RED("VerticalLineWidget")] public inkWidgetReference VerticalLineWidget { get; set; }
		[Ordinal(2)]  [RED("ActiveTextRef")] public inkTextWidgetReference ActiveTextRef { get; set; }
		[Ordinal(3)]  [RED("InActiveTextRef")] public inkTextWidgetReference InActiveTextRef { get; set; }
		[Ordinal(4)]  [RED("InActiveTextRootRef")] public inkWidgetReference InActiveTextRootRef { get; set; }
		[Ordinal(5)]  [RED("TextFlexRef")] public inkWidgetReference TextFlexRef { get; set; }
		[Ordinal(6)]  [RED("SelectedBgRef")] public inkWidgetReference SelectedBgRef { get; set; }
		[Ordinal(7)]  [RED("SelectedBgRefJohnny")] public inkWidgetReference SelectedBgRefJohnny { get; set; }
		[Ordinal(8)]  [RED("CaptionHolder")] public inkCompoundWidgetReference CaptionHolder { get; set; }
		[Ordinal(9)]  [RED("SecondaryCaptionHolder")] public inkCompoundWidgetReference SecondaryCaptionHolder { get; set; }
		[Ordinal(10)]  [RED("RootWidget")] public wCHandle<inkCompoundWidget> RootWidget { get; set; }
		[Ordinal(11)]  [RED("AnimationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(12)]  [RED("AnimationSpeed")] public CFloat AnimationSpeed { get; set; }
		[Ordinal(13)]  [RED("UseConstantSpeed")] public CBool UseConstantSpeed { get; set; }
		[Ordinal(14)]  [RED("phoneIcon")] public inkWidgetReference PhoneIcon { get; set; }
		[Ordinal(15)]  [RED("TextFlex")] public wCHandle<inkWidget> TextFlex { get; set; }
		[Ordinal(16)]  [RED("InActiveTextRoot")] public wCHandle<inkWidget> InActiveTextRoot { get; set; }
		[Ordinal(17)]  [RED("SelectedBg")] public wCHandle<inkWidget> SelectedBg { get; set; }
		[Ordinal(18)]  [RED("SelectedBgJohnny")] public wCHandle<inkWidget> SelectedBgJohnny { get; set; }
		[Ordinal(19)]  [RED("InputView")] public wCHandle<InteractionsInputView> InputView { get; set; }
		[Ordinal(20)]  [RED("CaptionControllers")] public CArray<wCHandle<CaptionImageIconsLogicController>> CaptionControllers { get; set; }
		[Ordinal(21)]  [RED("SecondaryCaptionControllers")] public CArray<wCHandle<CaptionImageIconsLogicController>> SecondaryCaptionControllers { get; set; }
		[Ordinal(22)]  [RED("type")] public gameinteractionsChoiceTypeWrapper Type { get; set; }
		[Ordinal(23)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(24)]  [RED("prevIsSelected")] public CBool PrevIsSelected { get; set; }
		[Ordinal(25)]  [RED("hasDedicatedInput")] public CBool HasDedicatedInput { get; set; }
		[Ordinal(26)]  [RED("overriddenInput")] public CBool OverriddenInput { get; set; }
		[Ordinal(27)]  [RED("isPreserveSelectionFadeOut")] public CBool IsPreserveSelectionFadeOut { get; set; }
		[Ordinal(28)]  [RED("isPhoneLockActive")] public CBool IsPhoneLockActive { get; set; }
		[Ordinal(29)]  [RED("dedicatedInputName")] public CName DedicatedInputName { get; set; }
		[Ordinal(30)]  [RED("Active")] public CName Active { get; set; }
		[Ordinal(31)]  [RED("Inactive")] public CName Inactive { get; set; }
		[Ordinal(32)]  [RED("Black")] public CName Black { get; set; }
		[Ordinal(33)]  [RED("questColor")] public CName QuestColor { get; set; }
		[Ordinal(34)]  [RED("possessedDialog")] public CName PossessedDialog { get; set; }
		[Ordinal(35)]  [RED("ControllerPromptLimit")] public CInt32 ControllerPromptLimit { get; set; }
		[Ordinal(36)]  [RED("fadingOptionEndTransparency")] public CFloat FadingOptionEndTransparency { get; set; }
		[Ordinal(37)]  [RED("animSelectedBgProxy")] public CHandle<inkanimProxy> AnimSelectedBgProxy { get; set; }
		[Ordinal(38)]  [RED("animSelectedJohnnyBgProxy")] public CHandle<inkanimProxy> AnimSelectedJohnnyBgProxy { get; set; }
		[Ordinal(39)]  [RED("animActiveTextProxy")] public CHandle<inkanimProxy> AnimActiveTextProxy { get; set; }
		[Ordinal(40)]  [RED("animfFadingOutProxy")] public CHandle<inkanimProxy> AnimfFadingOutProxy { get; set; }
		[Ordinal(41)]  [RED("animIntroProxy")] public CHandle<inkanimProxy> AnimIntroProxy { get; set; }

		public DialogChoiceLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
