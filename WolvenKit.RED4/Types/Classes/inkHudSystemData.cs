using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHudSystemData : inkILayerSystemData
	{
		[Ordinal(0)] 
		[RED("rootLibrary")] 
		public CResourceReference<inkWidgetLibraryResource> RootLibrary
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(1)] 
		[RED("entriesResource")] 
		public CResourceReference<inkHudEntriesResource> EntriesResource
		{
			get => GetPropertyValue<CResourceReference<inkHudEntriesResource>>();
			set => SetPropertyValue<CResourceReference<inkHudEntriesResource>>(value);
		}

		public inkHudSystemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
