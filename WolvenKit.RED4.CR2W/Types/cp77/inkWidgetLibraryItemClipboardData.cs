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
			get => GetProperty(ref _libraryItem);
			set => SetProperty(ref _libraryItem, value);
		}

		public inkWidgetLibraryItemClipboardData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
