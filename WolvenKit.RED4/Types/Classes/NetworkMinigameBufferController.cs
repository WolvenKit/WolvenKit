using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameBufferController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bufferSlotsContainer")] 
		public inkWidgetReference BufferSlotsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("slotList")] 
		public CArray<CWeakHandle<NetworkMinigameElementController>> SlotList
		{
			get => GetPropertyValue<CArray<CWeakHandle<NetworkMinigameElementController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NetworkMinigameElementController>>>(value);
		}

		[Ordinal(4)] 
		[RED("blinker")] 
		public inkWidgetReference Blinker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(8)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(9)] 
		[RED("currentAlpha")] 
		public CFloat CurrentAlpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("nextAlpha")] 
		public CFloat NextAlpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public NetworkMinigameBufferController()
		{
			BufferSlotsContainer = new();
			SlotList = new();
			Blinker = new();
			AnimOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
