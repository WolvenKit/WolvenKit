using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTutorialOverlayData : RedBaseClass
	{
		private redResourceReferenceScriptToken _widgetLibraryResource;
		private CName _itemName;

		[Ordinal(0)] 
		[RED("widgetLibraryResource")] 
		public redResourceReferenceScriptToken WidgetLibraryResource
		{
			get => GetProperty(ref _widgetLibraryResource);
			set => SetProperty(ref _widgetLibraryResource, value);
		}

		[Ordinal(1)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}
	}
}
