using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemClipboardData : ISerializable
	{
		private CHandle<inkWidgetLibraryItemUnpackedView> _libraryItem;

		[Ordinal(0)] 
		[RED("libraryItem")] 
		public CHandle<inkWidgetLibraryItemUnpackedView> LibraryItem
		{
			get
			{
				if (_libraryItem == null)
				{
					_libraryItem = (CHandle<inkWidgetLibraryItemUnpackedView>) CR2WTypeManager.Create("handle:inkWidgetLibraryItemUnpackedView", "libraryItem", cr2w, this);
				}
				return _libraryItem;
			}
			set
			{
				if (_libraryItem == value)
				{
					return;
				}
				_libraryItem = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryItemClipboardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
