using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHudEntriesResource : CResource
	{
		[Ordinal(1)] 
		[RED("rootWidget")] 
		public CResourceReference<inkWidgetLibraryResource> RootWidget
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(2)] 
		[RED("themeOverride")] 
		public CName ThemeOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<inkHudWidgetSpawnEntry> Entries
		{
			get => GetPropertyValue<CArray<inkHudWidgetSpawnEntry>>();
			set => SetPropertyValue<CArray<inkHudWidgetSpawnEntry>>(value);
		}

		public inkHudEntriesResource()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
