using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameGridCellController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("cellData")] 
		public CellData CellData
		{
			get => GetPropertyValue<CellData>();
			set => SetPropertyValue<CellData>(value);
		}

		[Ordinal(11)] 
		[RED("grid")] 
		public CWeakHandle<NetworkMinigameGridController> Grid
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameGridController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameGridController>>(value);
		}

		[Ordinal(12)] 
		[RED("slotsContainer")] 
		public inkWidgetReference SlotsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("slotsContent")] 
		public CWeakHandle<NetworkMinigameElementController> SlotsContent
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameElementController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameElementController>>(value);
		}

		[Ordinal(14)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public NetworkMinigameGridCellController()
		{
			CellData = new() { Position = new(), Element = new(), Properties = new() { Traps = new() } };
			SlotsContainer = new();
			DefaultColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
