using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHudEntriesResource : CResource
	{
		private rRef<inkWidgetLibraryResource> _rootWidget;
		private CName _themeOverride;
		private CArray<inkHudWidgetSpawnEntry> _entries;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public rRef<inkWidgetLibraryResource> RootWidget
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

		public inkHudEntriesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
