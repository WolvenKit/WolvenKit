using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			ItemSelected = new();
			ItemActivated = new();
			AllElementsSpawned = new();
			ItemTemplates = new();
			CycleNavigation = true;
		}
	}
}
