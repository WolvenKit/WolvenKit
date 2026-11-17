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
			ItemSelected = new inkVirtualCompoundControllerCallback { CallbackName = "OnItemSelected" };
			ItemActivated = new inkVirtualCompoundControllerCallback { CallbackName = "OnItemActivated" };
			AllElementsSpawned = new inkEmptyCallback { CallbackName = "OnAllElementsSpawned" };
			ItemTemplate = new inkWidgetLibraryReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
