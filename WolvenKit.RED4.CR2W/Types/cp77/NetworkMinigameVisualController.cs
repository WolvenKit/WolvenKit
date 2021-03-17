using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameVisualController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _gridContainer;
		private inkVideoWidgetReference _middleVideoContainer;
		private inkWidgetReference _sidesAnimContainer;
		private redResourceReferenceScriptToken _sidesLibraryPath;
		private CName _introAnimationLibraryName;
		private CName _gridOutroAnimationLibraryName;
		private CName _endScreenIntroAnimationLibraryName;
		private inkWidgetReference _programsContainer;
		private inkWidgetReference _bufferContainer;
		private inkWidgetReference _endScreenContainer;
		private CArray<inkWidgetReference> _fluffToHideContainer;
		private CArray<inkWidgetReference> _dottedLinesList;
		private inkWidgetReference _basicAccessContainer;
		private inkWidgetReference _animationCallbackContainer;
		private inkWidgetReference _dotMask;
		private CFloat _linesToGridOffset;
		private CFloat _linesSeparationDistance;
		private wCHandle<NetworkMinigameAnimationCallbacksTransmitter> _animationCallback;
		private wCHandle<NetworkMinigameGridController> _grid;
		private inkWidgetReference _gridController;
		private inkWidgetReference _programListController;
		private inkWidgetReference _bufferController;
		private inkWidgetReference _endScreenController;
		private wCHandle<NetworkMinigameProgramListController> _programList;
		private wCHandle<NetworkMinigameBufferController> _buffer;
		private wCHandle<NetworkMinigameEndScreenController> _endScreen;
		private wCHandle<NetworkMinigameBasicProgramController> _basicAccess;
		private wCHandle<inkWidget> _sidesAnim;
		private CInt32 _bufferFillCount;
		private CHandle<inkanimProxy> _bufferAnimProxy;
		private CHandle<inkanimDefinition> _fillProgress;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkCompoundWidgetReference GridContainer
		{
			get => GetProperty(ref _gridContainer);
			set => SetProperty(ref _gridContainer, value);
		}

		[Ordinal(2)] 
		[RED("middleVideoContainer")] 
		public inkVideoWidgetReference MiddleVideoContainer
		{
			get => GetProperty(ref _middleVideoContainer);
			set => SetProperty(ref _middleVideoContainer, value);
		}

		[Ordinal(3)] 
		[RED("sidesAnimContainer")] 
		public inkWidgetReference SidesAnimContainer
		{
			get => GetProperty(ref _sidesAnimContainer);
			set => SetProperty(ref _sidesAnimContainer, value);
		}

		[Ordinal(4)] 
		[RED("sidesLibraryPath")] 
		public redResourceReferenceScriptToken SidesLibraryPath
		{
			get => GetProperty(ref _sidesLibraryPath);
			set => SetProperty(ref _sidesLibraryPath, value);
		}

		[Ordinal(5)] 
		[RED("introAnimationLibraryName")] 
		public CName IntroAnimationLibraryName
		{
			get => GetProperty(ref _introAnimationLibraryName);
			set => SetProperty(ref _introAnimationLibraryName, value);
		}

		[Ordinal(6)] 
		[RED("gridOutroAnimationLibraryName")] 
		public CName GridOutroAnimationLibraryName
		{
			get => GetProperty(ref _gridOutroAnimationLibraryName);
			set => SetProperty(ref _gridOutroAnimationLibraryName, value);
		}

		[Ordinal(7)] 
		[RED("endScreenIntroAnimationLibraryName")] 
		public CName EndScreenIntroAnimationLibraryName
		{
			get => GetProperty(ref _endScreenIntroAnimationLibraryName);
			set => SetProperty(ref _endScreenIntroAnimationLibraryName, value);
		}

		[Ordinal(8)] 
		[RED("programsContainer")] 
		public inkWidgetReference ProgramsContainer
		{
			get => GetProperty(ref _programsContainer);
			set => SetProperty(ref _programsContainer, value);
		}

		[Ordinal(9)] 
		[RED("bufferContainer")] 
		public inkWidgetReference BufferContainer
		{
			get => GetProperty(ref _bufferContainer);
			set => SetProperty(ref _bufferContainer, value);
		}

		[Ordinal(10)] 
		[RED("endScreenContainer")] 
		public inkWidgetReference EndScreenContainer
		{
			get => GetProperty(ref _endScreenContainer);
			set => SetProperty(ref _endScreenContainer, value);
		}

		[Ordinal(11)] 
		[RED("FluffToHideContainer")] 
		public CArray<inkWidgetReference> FluffToHideContainer
		{
			get => GetProperty(ref _fluffToHideContainer);
			set => SetProperty(ref _fluffToHideContainer, value);
		}

		[Ordinal(12)] 
		[RED("DottedLinesList")] 
		public CArray<inkWidgetReference> DottedLinesList
		{
			get => GetProperty(ref _dottedLinesList);
			set => SetProperty(ref _dottedLinesList, value);
		}

		[Ordinal(13)] 
		[RED("basicAccessContainer")] 
		public inkWidgetReference BasicAccessContainer
		{
			get => GetProperty(ref _basicAccessContainer);
			set => SetProperty(ref _basicAccessContainer, value);
		}

		[Ordinal(14)] 
		[RED("animationCallbackContainer")] 
		public inkWidgetReference AnimationCallbackContainer
		{
			get => GetProperty(ref _animationCallbackContainer);
			set => SetProperty(ref _animationCallbackContainer, value);
		}

		[Ordinal(15)] 
		[RED("dotMask")] 
		public inkWidgetReference DotMask
		{
			get => GetProperty(ref _dotMask);
			set => SetProperty(ref _dotMask, value);
		}

		[Ordinal(16)] 
		[RED("linesToGridOffset")] 
		public CFloat LinesToGridOffset
		{
			get => GetProperty(ref _linesToGridOffset);
			set => SetProperty(ref _linesToGridOffset, value);
		}

		[Ordinal(17)] 
		[RED("linesSeparationDistance")] 
		public CFloat LinesSeparationDistance
		{
			get => GetProperty(ref _linesSeparationDistance);
			set => SetProperty(ref _linesSeparationDistance, value);
		}

		[Ordinal(18)] 
		[RED("animationCallback")] 
		public wCHandle<NetworkMinigameAnimationCallbacksTransmitter> AnimationCallback
		{
			get => GetProperty(ref _animationCallback);
			set => SetProperty(ref _animationCallback, value);
		}

		[Ordinal(19)] 
		[RED("grid")] 
		public wCHandle<NetworkMinigameGridController> Grid
		{
			get => GetProperty(ref _grid);
			set => SetProperty(ref _grid, value);
		}

		[Ordinal(20)] 
		[RED("gridController")] 
		public inkWidgetReference GridController
		{
			get => GetProperty(ref _gridController);
			set => SetProperty(ref _gridController, value);
		}

		[Ordinal(21)] 
		[RED("programListController")] 
		public inkWidgetReference ProgramListController
		{
			get => GetProperty(ref _programListController);
			set => SetProperty(ref _programListController, value);
		}

		[Ordinal(22)] 
		[RED("bufferController")] 
		public inkWidgetReference BufferController
		{
			get => GetProperty(ref _bufferController);
			set => SetProperty(ref _bufferController, value);
		}

		[Ordinal(23)] 
		[RED("endScreenController")] 
		public inkWidgetReference EndScreenController
		{
			get => GetProperty(ref _endScreenController);
			set => SetProperty(ref _endScreenController, value);
		}

		[Ordinal(24)] 
		[RED("programList")] 
		public wCHandle<NetworkMinigameProgramListController> ProgramList
		{
			get => GetProperty(ref _programList);
			set => SetProperty(ref _programList, value);
		}

		[Ordinal(25)] 
		[RED("buffer")] 
		public wCHandle<NetworkMinigameBufferController> Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		[Ordinal(26)] 
		[RED("endScreen")] 
		public wCHandle<NetworkMinigameEndScreenController> EndScreen
		{
			get => GetProperty(ref _endScreen);
			set => SetProperty(ref _endScreen, value);
		}

		[Ordinal(27)] 
		[RED("basicAccess")] 
		public wCHandle<NetworkMinigameBasicProgramController> BasicAccess
		{
			get => GetProperty(ref _basicAccess);
			set => SetProperty(ref _basicAccess, value);
		}

		[Ordinal(28)] 
		[RED("sidesAnim")] 
		public wCHandle<inkWidget> SidesAnim
		{
			get => GetProperty(ref _sidesAnim);
			set => SetProperty(ref _sidesAnim, value);
		}

		[Ordinal(29)] 
		[RED("bufferFillCount")] 
		public CInt32 BufferFillCount
		{
			get => GetProperty(ref _bufferFillCount);
			set => SetProperty(ref _bufferFillCount, value);
		}

		[Ordinal(30)] 
		[RED("bufferAnimProxy")] 
		public CHandle<inkanimProxy> BufferAnimProxy
		{
			get => GetProperty(ref _bufferAnimProxy);
			set => SetProperty(ref _bufferAnimProxy, value);
		}

		[Ordinal(31)] 
		[RED("fillProgress")] 
		public CHandle<inkanimDefinition> FillProgress
		{
			get => GetProperty(ref _fillProgress);
			set => SetProperty(ref _fillProgress, value);
		}

		public NetworkMinigameVisualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
