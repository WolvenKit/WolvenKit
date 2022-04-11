using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameProgramController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("commandElementSlotsContainer")] 
		public CArray<inkWidgetReference> CommandElementSlotsContainer
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("completedMarker")] 
		public inkWidgetReference CompletedMarker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("slotList")] 
		public CArray<CArray<CWeakHandle<NetworkMinigameElementController>>> SlotList
		{
			get => GetPropertyValue<CArray<CArray<CWeakHandle<NetworkMinigameElementController>>>>();
			set => SetPropertyValue<CArray<CArray<CWeakHandle<NetworkMinigameElementController>>>>(value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public ProgramData Data
		{
			get => GetPropertyValue<ProgramData>();
			set => SetPropertyValue<ProgramData>(value);
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public NetworkMinigameProgramController()
		{
			Text = new();
			CommandElementSlotsContainer = new();
			CompletedMarker = new();
			ImageRef = new();
			SlotList = new();
			Data = new() { CommandLists = new(), Effects = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
