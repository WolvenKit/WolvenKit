using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualListController : inkVirtualCompoundController
	{
		[Ordinal(7)] 
		[RED("itemTemplates")] 
		public CArray<inkWidgetLibraryReference> ItemTemplates
		{
			get => GetPropertyValue<CArray<inkWidgetLibraryReference>>();
			set => SetPropertyValue<CArray<inkWidgetLibraryReference>>(value);
		}

		[Ordinal(8)] 
		[RED("cycleNavigation")] 
		public CBool CycleNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkVirtualListController()
		{
			ItemSelected = new inkVirtualCompoundControllerCallback();
			ItemActivated = new inkVirtualCompoundControllerCallback();
			AllElementsSpawned = new inkEmptyCallback();
			ItemTemplates = new();
			CycleNavigation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
