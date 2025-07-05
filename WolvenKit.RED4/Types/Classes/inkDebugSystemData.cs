using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDebugSystemData : inkILayerSystemData
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<inkDebugLayerEntry> Entries
		{
			get => GetPropertyValue<CArray<inkDebugLayerEntry>>();
			set => SetPropertyValue<CArray<inkDebugLayerEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("rootLibrary")] 
		public CResourceReference<inkWidgetLibraryResource> RootLibrary
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		public inkDebugSystemData()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
