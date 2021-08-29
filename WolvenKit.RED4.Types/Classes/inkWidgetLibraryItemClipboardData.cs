using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryItemClipboardData : ISerializable
	{
		private CHandle<inkWidgetLibraryItemUnpackedView> _libraryItem;

		[Ordinal(0)] 
		[RED("libraryItem")] 
		public CHandle<inkWidgetLibraryItemUnpackedView> LibraryItem
		{
			get => GetProperty(ref _libraryItem);
			set => SetProperty(ref _libraryItem, value);
		}
	}
}
