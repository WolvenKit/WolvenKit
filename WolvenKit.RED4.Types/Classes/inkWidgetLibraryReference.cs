using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryReference : RedBaseClass
	{
		private inkWidgetLibraryResourceWrapper _widgetLibrary;
		private CName _widgetItem;

		[Ordinal(0)] 
		[RED("widgetLibrary")] 
		public inkWidgetLibraryResourceWrapper WidgetLibrary
		{
			get => GetProperty(ref _widgetLibrary);
			set => SetProperty(ref _widgetLibrary, value);
		}

		[Ordinal(1)] 
		[RED("widgetItem")] 
		public CName WidgetItem
		{
			get => GetProperty(ref _widgetItem);
			set => SetProperty(ref _widgetItem, value);
		}
	}
}
