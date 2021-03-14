using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryUnpackedView : ISerializable
	{
		private CArray<CHandle<inkWidgetLibraryItemUnpackedView>> _libraryItems;
		private CArray<rRef<inkWidgetLibraryResource>> _externalLibraries;

		[Ordinal(0)] 
		[RED("libraryItems")] 
		public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems
		{
			get
			{
				if (_libraryItems == null)
				{
					_libraryItems = (CArray<CHandle<inkWidgetLibraryItemUnpackedView>>) CR2WTypeManager.Create("array:handle:inkWidgetLibraryItemUnpackedView", "libraryItems", cr2w, this);
				}
				return _libraryItems;
			}
			set
			{
				if (_libraryItems == value)
				{
					return;
				}
				_libraryItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("externalLibraries")] 
		public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries
		{
			get
			{
				if (_externalLibraries == null)
				{
					_externalLibraries = (CArray<rRef<inkWidgetLibraryResource>>) CR2WTypeManager.Create("array:rRef:inkWidgetLibraryResource", "externalLibraries", cr2w, this);
				}
				return _externalLibraries;
			}
			set
			{
				if (_externalLibraries == value)
				{
					return;
				}
				_externalLibraries = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
