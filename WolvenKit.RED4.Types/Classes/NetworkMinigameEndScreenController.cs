using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkMinigameEndScreenController : inkWidgetLogicController
	{
		private inkTextWidgetReference _outcomeText;
		private CWeakHandle<NetworkMinigameProgramController> _finishBarContainer;
		private inkWidgetReference _programsListContainer;
		private CName _programLibraryName;
		private CArray<CWeakHandle<NetworkMinigameProgramController>> _slotList;
		private EndScreenData _endData;
		private inkWidgetReference _closeButton;
		private inkWidgetReference _header_bg;
		private CColor _completionColor;
		private CColor _failureColor;

		[Ordinal(1)] 
		[RED("outcomeText")] 
		public inkTextWidgetReference OutcomeText
		{
			get => GetProperty(ref _outcomeText);
			set => SetProperty(ref _outcomeText, value);
		}

		[Ordinal(2)] 
		[RED("finishBarContainer")] 
		public CWeakHandle<NetworkMinigameProgramController> FinishBarContainer
		{
			get => GetProperty(ref _finishBarContainer);
			set => SetProperty(ref _finishBarContainer, value);
		}

		[Ordinal(3)] 
		[RED("programsListContainer")] 
		public inkWidgetReference ProgramsListContainer
		{
			get => GetProperty(ref _programsListContainer);
			set => SetProperty(ref _programsListContainer, value);
		}

		[Ordinal(4)] 
		[RED("programLibraryName")] 
		public CName ProgramLibraryName
		{
			get => GetProperty(ref _programLibraryName);
			set => SetProperty(ref _programLibraryName, value);
		}

		[Ordinal(5)] 
		[RED("slotList")] 
		public CArray<CWeakHandle<NetworkMinigameProgramController>> SlotList
		{
			get => GetProperty(ref _slotList);
			set => SetProperty(ref _slotList, value);
		}

		[Ordinal(6)] 
		[RED("endData")] 
		public EndScreenData EndData
		{
			get => GetProperty(ref _endData);
			set => SetProperty(ref _endData, value);
		}

		[Ordinal(7)] 
		[RED("closeButton")] 
		public inkWidgetReference CloseButton
		{
			get => GetProperty(ref _closeButton);
			set => SetProperty(ref _closeButton, value);
		}

		[Ordinal(8)] 
		[RED("header_bg")] 
		public inkWidgetReference Header_bg
		{
			get => GetProperty(ref _header_bg);
			set => SetProperty(ref _header_bg, value);
		}

		[Ordinal(9)] 
		[RED("completionColor")] 
		public CColor CompletionColor
		{
			get => GetProperty(ref _completionColor);
			set => SetProperty(ref _completionColor, value);
		}

		[Ordinal(10)] 
		[RED("failureColor")] 
		public CColor FailureColor
		{
			get => GetProperty(ref _failureColor);
			set => SetProperty(ref _failureColor, value);
		}
	}
}
