using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualUniformListController : inkVirtualCompoundController
	{
		[Ordinal(7)] 
		[RED("itemTemplate")] 
		public inkWidgetLibraryReference ItemTemplate
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public inkVirtualUniformListController()
		{
			ItemSelected = new();
			ItemActivated = new();
			AllElementsSpawned = new();
			ItemTemplate = new() { WidgetLibrary = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
