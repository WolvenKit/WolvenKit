using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryUnpackedView : ISerializable
	{
		[Ordinal(0)] 
		[RED("libraryItems")] 
		public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems
		{
			get => GetPropertyValue<CArray<CHandle<inkWidgetLibraryItemUnpackedView>>>();
			set => SetPropertyValue<CArray<CHandle<inkWidgetLibraryItemUnpackedView>>>(value);
		}

		[Ordinal(1)] 
		[RED("externalLibraries")] 
		public CArray<CResourceReference<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetPropertyValue<CArray<CResourceReference<inkWidgetLibraryResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<inkWidgetLibraryResource>>>(value);
		}

		public inkWidgetLibraryUnpackedView()
		{
			LibraryItems = new();
			ExternalLibraries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
