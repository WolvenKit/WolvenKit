using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetLibrary")] 
		public inkWidgetLibraryResourceWrapper WidgetLibrary
		{
			get => GetPropertyValue<inkWidgetLibraryResourceWrapper>();
			set => SetPropertyValue<inkWidgetLibraryResourceWrapper>(value);
		}

		[Ordinal(1)] 
		[RED("widgetItem")] 
		public CName WidgetItem
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkWidgetLibraryReference()
		{
			WidgetLibrary = new inkWidgetLibraryResourceWrapper();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
