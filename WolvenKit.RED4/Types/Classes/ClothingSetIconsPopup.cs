using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClothingSetIconsPopup : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("iconGrid")] 
		public inkWidgetReference IconGrid
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<ClothingSetIconsPopupData> Data
		{
			get => GetPropertyValue<CHandle<ClothingSetIconsPopupData>>();
			set => SetPropertyValue<CHandle<ClothingSetIconsPopupData>>(value);
		}

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public ClothingSetIconsPopup()
		{
			IconGrid = new inkWidgetReference();
			ButtonHintsRoot = new inkWidgetReference();
			LibraryPath = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
