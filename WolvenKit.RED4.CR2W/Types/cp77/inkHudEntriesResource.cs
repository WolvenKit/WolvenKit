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
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("themeOverride")] 
		public CName ThemeOverride
		{
			get
			{
				if (_themeOverride == null)
				{
					_themeOverride = (CName) CR2WTypeManager.Create("CName", "themeOverride", cr2w, this);
				}
				return _themeOverride;
			}
			set
			{
				if (_themeOverride == value)
				{
					return;
				}
				_themeOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<inkHudWidgetSpawnEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<inkHudWidgetSpawnEntry>) CR2WTypeManager.Create("array:inkHudWidgetSpawnEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public inkHudEntriesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
