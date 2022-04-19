using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryResourceWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("library")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> Library
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		public inkWidgetLibraryResourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
