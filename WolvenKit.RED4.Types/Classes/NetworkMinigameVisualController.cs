using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameVisualController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkCompoundWidgetReference GridContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("middleVideoContainer")] 
		public inkVideoWidgetReference MiddleVideoContainer
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("sidesAnimContainer")] 
		public inkWidgetReference SidesAnimContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("sidesLibraryPath")] 
		public redResourceReferenceScriptToken SidesLibraryPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(5)] 
		[RED("introAnimationLibraryName")] 
		public CName IntroAnimationLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("gridOutroAnimationLibraryName")] 
		public CName GridOutroAnimationLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("endScreenIntroAnimationLibraryName")] 
		public CName EndScreenIntroAnimationLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("programsContainer")] 
		public inkWidgetReference ProgramsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("bufferContainer")] 
		public inkWidgetReference BufferContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("endScreenContainer")] 
		public inkWidgetReference EndScreenContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("FluffToHideContainer")] 
		public CArray<inkWidgetReference> FluffToHideContainer
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(12)] 
		[RED("DottedLinesList")] 
		public CArray<inkWidgetReference> DottedLinesList
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(13)] 
		[RED("basicAccessContainer")] 
		public inkWidgetReference BasicAccessContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("animationCallbackContainer")] 
		public inkWidgetReference AnimationCallbackContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("dotMask")] 
		public inkWidgetReference DotMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("linesToGridOffset")] 
		public CFloat LinesToGridOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("linesSeparationDistance")] 
		public CFloat LinesSeparationDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("animationCallback")] 
		public CWeakHandle<NetworkMinigameAnimationCallbacksTransmitter> AnimationCallback
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameAnimationCallbacksTransmitter>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameAnimationCallbacksTransmitter>>(value);
		}

		[Ordinal(19)] 
		[RED("grid")] 
		public CWeakHandle<NetworkMinigameGridController> Grid
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameGridController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameGridController>>(value);
		}

		[Ordinal(20)] 
		[RED("gridController")] 
		public inkWidgetReference GridController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("programListController")] 
		public inkWidgetReference ProgramListController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("bufferController")] 
		public inkWidgetReference BufferController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("endScreenController")] 
		public inkWidgetReference EndScreenController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("programList")] 
		public CWeakHandle<NetworkMinigameProgramListController> ProgramList
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameProgramListController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameProgramListController>>(value);
		}

		[Ordinal(25)] 
		[RED("buffer")] 
		public CWeakHandle<NetworkMinigameBufferController> Buffer
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameBufferController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameBufferController>>(value);
		}

		[Ordinal(26)] 
		[RED("endScreen")] 
		public CWeakHandle<NetworkMinigameEndScreenController> EndScreen
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameEndScreenController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameEndScreenController>>(value);
		}

		[Ordinal(27)] 
		[RED("basicAccess")] 
		public CWeakHandle<NetworkMinigameBasicProgramController> BasicAccess
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameBasicProgramController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameBasicProgramController>>(value);
		}

		[Ordinal(28)] 
		[RED("sidesAnim")] 
		public CWeakHandle<inkWidget> SidesAnim
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("bufferFillCount")] 
		public CInt32 BufferFillCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("bufferAnimProxy")] 
		public CHandle<inkanimProxy> BufferAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("fillProgress")] 
		public CHandle<inkanimDefinition> FillProgress
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		public NetworkMinigameVisualController()
		{
			GridContainer = new();
			MiddleVideoContainer = new();
			SidesAnimContainer = new();
			SidesLibraryPath = new();
			ProgramsContainer = new();
			BufferContainer = new();
			EndScreenContainer = new();
			FluffToHideContainer = new();
			DottedLinesList = new();
			BasicAccessContainer = new();
			AnimationCallbackContainer = new();
			DotMask = new();
			GridController = new();
			ProgramListController = new();
			BufferController = new();
			EndScreenController = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
