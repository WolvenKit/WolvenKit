using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryItemClipboardData : ISerializable
	{
		[Ordinal(0)] 
		[RED("libraryItem")] 
		public CHandle<inkWidgetLibraryItemUnpackedView> LibraryItem
		{
			get => GetPropertyValue<CHandle<inkWidgetLibraryItemUnpackedView>>();
			set => SetPropertyValue<CHandle<inkWidgetLibraryItemUnpackedView>>(value);
		}

		public inkWidgetLibraryItemClipboardData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
