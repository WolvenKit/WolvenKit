using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameGridCellController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("cellData")] 
		public CellData CellData
		{
			get => GetPropertyValue<CellData>();
			set => SetPropertyValue<CellData>(value);
		}

		[Ordinal(14)] 
		[RED("grid")] 
		public CWeakHandle<NetworkMinigameGridController> Grid
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameGridController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameGridController>>(value);
		}

		[Ordinal(15)] 
		[RED("slotsContainer")] 
		public inkWidgetReference SlotsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("slotsContent")] 
		public CWeakHandle<NetworkMinigameElementController> SlotsContent
		{
			get => GetPropertyValue<CWeakHandle<NetworkMinigameElementController>>();
			set => SetPropertyValue<CWeakHandle<NetworkMinigameElementController>>(value);
		}

		[Ordinal(17)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		public NetworkMinigameGridCellController()
		{
			CellData = new CellData { Position = new Vector2(), Element = new ElementData(), Properties = new SpecialProperties { Traps = new() } };
			SlotsContainer = new inkWidgetReference();
			DefaultColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
