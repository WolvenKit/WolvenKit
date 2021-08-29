using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryUnpackedView : ISerializable
	{
		private CArray<CHandle<inkWidgetLibraryItemUnpackedView>> _libraryItems;
		private CArray<CResourceReference<inkWidgetLibraryResource>> _externalLibraries;

		[Ordinal(0)] 
		[RED("libraryItems")] 
		public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems
		{
			get => GetProperty(ref _libraryItems);
			set => SetProperty(ref _libraryItems, value);
		}

		[Ordinal(1)] 
		[RED("externalLibraries")] 
		public CArray<CResourceReference<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetProperty(ref _externalLibraries);
			set => SetProperty(ref _externalLibraries, value);
		}
	}
}
