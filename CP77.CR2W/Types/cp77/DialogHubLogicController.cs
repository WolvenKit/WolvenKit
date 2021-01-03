using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DialogHubLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animSelectMargin")] public CHandle<inkanimDefinition> AnimSelectMargin { get; set; }
		[Ordinal(1)]  [RED("animSelectMarginProxy")] public CHandle<inkanimProxy> AnimSelectMarginProxy { get; set; }
		[Ordinal(2)]  [RED("animSelectSize")] public CHandle<inkanimDefinition> AnimSelectSize { get; set; }
		[Ordinal(3)]  [RED("animSelectSizeProxy")] public CHandle<inkanimProxy> AnimSelectSizeProxy { get; set; }
		[Ordinal(4)]  [RED("animfFadingOutProxy")] public CHandle<inkanimProxy> AnimfFadingOutProxy { get; set; }
		[Ordinal(5)]  [RED("data")] public gameinteractionsvisListChoiceHubData Data { get; set; }
		[Ordinal(6)]  [RED("hasProgressBar")] public CBool HasProgressBar { get; set; }
		[Ordinal(7)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(8)]  [RED("inActiveTransparency")] public CFloat InActiveTransparency { get; set; }
		[Ordinal(9)]  [RED("isClosingDelayed")] public CBool IsClosingDelayed { get; set; }
		[Ordinal(10)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(11)]  [RED("itemControllers")] public CArray<CHandle<DialogChoiceLogicController>> ItemControllers { get; set; }
		[Ordinal(12)]  [RED("lastSelectedIdx")] public CInt32 LastSelectedIdx { get; set; }
		[Ordinal(13)]  [RED("mainVert")] public wCHandle<inkCompoundWidget> MainVert { get; set; }
		[Ordinal(14)]  [RED("moveAnimTime")] public CFloat MoveAnimTime { get; set; }
		[Ordinal(15)]  [RED("possessedDialogFluff")] public wCHandle<inkWidget> PossessedDialogFluff { get; set; }
		[Ordinal(16)]  [RED("progressBar")] public CHandle<DialogChoiceTimerController> ProgressBar { get; set; }
		[Ordinal(17)]  [RED("progressBarHolder")] public inkWidgetReference ProgressBarHolder { get; set; }
		[Ordinal(18)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(19)]  [RED("selectBgMarginInterp")] public CHandle<inkanimMarginInterpolator> SelectBgMarginInterp { get; set; }
		[Ordinal(20)]  [RED("selectBgSizeInterp")] public CHandle<inkanimSizeInterpolator> SelectBgSizeInterp { get; set; }
		[Ordinal(21)]  [RED("selectionRoot")] public inkWidgetReference SelectionRoot { get; set; }
		[Ordinal(22)]  [RED("selectionSizeProviderRef")] public inkWidgetReference SelectionSizeProviderRef { get; set; }
		[Ordinal(23)]  [RED("titleBorder")] public wCHandle<inkWidget> TitleBorder { get; set; }
		[Ordinal(24)]  [RED("titleContainer")] public wCHandle<inkCompoundWidget> TitleContainer { get; set; }
		[Ordinal(25)]  [RED("titleWidget")] public wCHandle<inkTextWidget> TitleWidget { get; set; }
		[Ordinal(26)]  [RED("wasTimmed")] public CBool WasTimmed { get; set; }

		public DialogHubLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
