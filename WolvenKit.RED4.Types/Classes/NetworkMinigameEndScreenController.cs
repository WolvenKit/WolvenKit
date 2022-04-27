using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameEndScreenController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("outcomeText")] 
		public inkTextWidgetReference OutcomeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("finishBarContainer")] 
		public CWeakHandle<NetworkMinigameProgramController> FinishBarContainer
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameProgramController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameProgramController>>(value);
		}

		[Ordinal(3)] 
		[RED("programsListContainer")] 
		public inkWidgetReference ProgramsListContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("programLibraryName")] 
		public CName ProgramLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("slotList")] 
		public CArray<CWeakHandle<NetworkMinigameProgramController>> SlotList
		{
			get => GetPropertyValue<CArray<CWeakHandle<NetworkMinigameProgramController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NetworkMinigameProgramController>>>(value);
		}

		[Ordinal(6)] 
		[RED("endData")] 
		public EndScreenData EndData
		{
			get => GetPropertyValue<EndScreenData>();
			set => SetPropertyValue<EndScreenData>(value);
		}

		[Ordinal(7)] 
		[RED("closeButton")] 
		public inkWidgetReference CloseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("header_bg")] 
		public inkWidgetReference Header_bg
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("completionColor")] 
		public CColor CompletionColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(10)] 
		[RED("failureColor")] 
		public CColor FailureColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public NetworkMinigameEndScreenController()
		{
			OutcomeText = new();
			ProgramsListContainer = new();
			SlotList = new();
			EndData = new() { UnlockedPrograms = new() };
			CloseButton = new();
			Header_bg = new();
			CompletionColor = new();
			FailureColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
