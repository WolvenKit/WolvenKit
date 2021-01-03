using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameVisualController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("DottedLinesList")] public CArray<inkWidgetReference> DottedLinesList { get; set; }
		[Ordinal(1)]  [RED("FluffToHideContainer")] public CArray<inkWidgetReference> FluffToHideContainer { get; set; }
		[Ordinal(2)]  [RED("animationCallback")] public wCHandle<NetworkMinigameAnimationCallbacksTransmitter> AnimationCallback { get; set; }
		[Ordinal(3)]  [RED("animationCallbackContainer")] public inkWidgetReference AnimationCallbackContainer { get; set; }
		[Ordinal(4)]  [RED("basicAccess")] public wCHandle<NetworkMinigameBasicProgramController> BasicAccess { get; set; }
		[Ordinal(5)]  [RED("basicAccessContainer")] public inkWidgetReference BasicAccessContainer { get; set; }
		[Ordinal(6)]  [RED("buffer")] public wCHandle<NetworkMinigameBufferController> Buffer { get; set; }
		[Ordinal(7)]  [RED("bufferAnimProxy")] public CHandle<inkanimProxy> BufferAnimProxy { get; set; }
		[Ordinal(8)]  [RED("bufferContainer")] public inkWidgetReference BufferContainer { get; set; }
		[Ordinal(9)]  [RED("bufferController")] public inkWidgetReference BufferController { get; set; }
		[Ordinal(10)]  [RED("bufferFillCount")] public CInt32 BufferFillCount { get; set; }
		[Ordinal(11)]  [RED("dotMask")] public inkWidgetReference DotMask { get; set; }
		[Ordinal(12)]  [RED("endScreen")] public wCHandle<NetworkMinigameEndScreenController> EndScreen { get; set; }
		[Ordinal(13)]  [RED("endScreenContainer")] public inkWidgetReference EndScreenContainer { get; set; }
		[Ordinal(14)]  [RED("endScreenController")] public inkWidgetReference EndScreenController { get; set; }
		[Ordinal(15)]  [RED("endScreenIntroAnimationLibraryName")] public CName EndScreenIntroAnimationLibraryName { get; set; }
		[Ordinal(16)]  [RED("fillProgress")] public CHandle<inkanimDefinition> FillProgress { get; set; }
		[Ordinal(17)]  [RED("grid")] public wCHandle<NetworkMinigameGridController> Grid { get; set; }
		[Ordinal(18)]  [RED("gridContainer")] public inkCompoundWidgetReference GridContainer { get; set; }
		[Ordinal(19)]  [RED("gridController")] public inkWidgetReference GridController { get; set; }
		[Ordinal(20)]  [RED("gridOutroAnimationLibraryName")] public CName GridOutroAnimationLibraryName { get; set; }
		[Ordinal(21)]  [RED("introAnimationLibraryName")] public CName IntroAnimationLibraryName { get; set; }
		[Ordinal(22)]  [RED("linesSeparationDistance")] public CFloat LinesSeparationDistance { get; set; }
		[Ordinal(23)]  [RED("linesToGridOffset")] public CFloat LinesToGridOffset { get; set; }
		[Ordinal(24)]  [RED("middleVideoContainer")] public inkVideoWidgetReference MiddleVideoContainer { get; set; }
		[Ordinal(25)]  [RED("programList")] public wCHandle<NetworkMinigameProgramListController> ProgramList { get; set; }
		[Ordinal(26)]  [RED("programListController")] public inkWidgetReference ProgramListController { get; set; }
		[Ordinal(27)]  [RED("programsContainer")] public inkWidgetReference ProgramsContainer { get; set; }
		[Ordinal(28)]  [RED("sidesAnim")] public wCHandle<inkWidget> SidesAnim { get; set; }
		[Ordinal(29)]  [RED("sidesAnimContainer")] public inkWidgetReference SidesAnimContainer { get; set; }
		[Ordinal(30)]  [RED("sidesLibraryPath")] public redResourceReferenceScriptToken SidesLibraryPath { get; set; }

		public NetworkMinigameVisualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
