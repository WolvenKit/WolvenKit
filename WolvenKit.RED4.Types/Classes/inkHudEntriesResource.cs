using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHudEntriesResource : CResource
	{
		private CResourceReference<inkWidgetLibraryResource> _rootWidget;
		private CName _themeOverride;
		private CArray<inkHudWidgetSpawnEntry> _entries;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public CResourceReference<inkWidgetLibraryResource> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(2)] 
		[RED("themeOverride")] 
		public CName ThemeOverride
		{
			get => GetProperty(ref _themeOverride);
			set => SetProperty(ref _themeOverride, value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<inkHudWidgetSpawnEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
