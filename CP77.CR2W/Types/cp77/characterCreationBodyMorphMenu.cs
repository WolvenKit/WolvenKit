using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("eventDispatcher")] public wCHandle<inkMenuEventDispatcher> EventDispatcher { get; set; }
		[Ordinal(2)]  [RED("characterCustomizationState")] public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState { get; set; }
		[Ordinal(3)]  [RED("nextPageHitArea")] public inkWidgetReference NextPageHitArea { get; set; }
		[Ordinal(4)]  [RED("defaultPreviewSlot")] public CName DefaultPreviewSlot { get; set; }
		[Ordinal(5)]  [RED("optionsList")] public inkCompoundWidgetReference OptionsList { get; set; }
		[Ordinal(6)]  [RED("colorPicker")] public inkWidgetReference ColorPicker { get; set; }
		[Ordinal(7)]  [RED("colorPickerBG")] public inkWidgetReference ColorPickerBG { get; set; }
		[Ordinal(8)]  [RED("colorPickerClose")] public inkWidgetReference ColorPickerClose { get; set; }
		[Ordinal(9)]  [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(10)]  [RED("optionList")] public CHandle<inkCompoundWidget> OptionList { get; set; }
		[Ordinal(11)]  [RED("previousPageBtn")] public inkWidgetReference PreviousPageBtn { get; set; }
		[Ordinal(12)]  [RED("previousPageBtnBg")] public inkImageWidgetReference PreviousPageBtnBg { get; set; }
		[Ordinal(13)]  [RED("nextPageBtnBg")] public inkImageWidgetReference NextPageBtnBg { get; set; }
		[Ordinal(14)]  [RED("backConfirmation")] public inkWidgetReference BackConfirmation { get; set; }
		[Ordinal(15)]  [RED("backConfirmationWidget")] public inkWidgetReference BackConfirmationWidget { get; set; }
		[Ordinal(16)]  [RED("ConfirmationConfirmBtn")] public inkWidgetReference ConfirmationConfirmBtn { get; set; }
		[Ordinal(17)]  [RED("ConfirmationCloseBtn")] public inkWidgetReference ConfirmationCloseBtn { get; set; }
		[Ordinal(18)]  [RED("preset1")] public inkWidgetReference Preset1 { get; set; }
		[Ordinal(19)]  [RED("preset2")] public inkWidgetReference Preset2 { get; set; }
		[Ordinal(20)]  [RED("preset3")] public inkWidgetReference Preset3 { get; set; }
		[Ordinal(21)]  [RED("randomize")] public inkWidgetReference Randomize { get; set; }
		[Ordinal(22)]  [RED("preset1Thumbnail")] public inkImageWidgetReference Preset1Thumbnail { get; set; }
		[Ordinal(23)]  [RED("preset2Thumbnail")] public inkImageWidgetReference Preset2Thumbnail { get; set; }
		[Ordinal(24)]  [RED("preset3Thumbnail")] public inkImageWidgetReference Preset3Thumbnail { get; set; }
		[Ordinal(25)]  [RED("randomizThumbnail")] public inkImageWidgetReference RandomizThumbnail { get; set; }
		[Ordinal(26)]  [RED("preset1Bg")] public inkImageWidgetReference Preset1Bg { get; set; }
		[Ordinal(27)]  [RED("preset2Bg")] public inkImageWidgetReference Preset2Bg { get; set; }
		[Ordinal(28)]  [RED("preset3Bg")] public inkImageWidgetReference Preset3Bg { get; set; }
		[Ordinal(29)]  [RED("randomizBg")] public inkImageWidgetReference RandomizBg { get; set; }
		[Ordinal(30)]  [RED("navigationButtons")] public inkWidgetReference NavigationButtons { get; set; }
		[Ordinal(31)]  [RED("hideColorPickerNextFrame")] public CBool HideColorPickerNextFrame { get; set; }
		[Ordinal(32)]  [RED("colorPickerOwner")] public wCHandle<inkWidget> ColorPickerOwner { get; set; }
		[Ordinal(33)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(34)]  [RED("confirmAnimationProxy")] public CHandle<inkanimProxy> ConfirmAnimationProxy { get; set; }
		[Ordinal(35)]  [RED("optionListAnimationProxy")] public CHandle<inkanimProxy> OptionListAnimationProxy { get; set; }
		[Ordinal(36)]  [RED("optionsListInitialized")] public CBool OptionsListInitialized { get; set; }
		[Ordinal(37)]  [RED("introPlayed")] public CBool IntroPlayed { get; set; }
		[Ordinal(38)]  [RED("menuListController")] public wCHandle<inkListController> MenuListController { get; set; }
		[Ordinal(39)]  [RED("cachedCursor")] public wCHandle<inkWidget> CachedCursor { get; set; }

		public characterCreationBodyMorphMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
