using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHUDLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("entriesResource")] 
		public CResourceReference<inkHudEntriesResource> EntriesResource
		{
			get => GetPropertyValue<CResourceReference<inkHudEntriesResource>>();
			set => SetPropertyValue<CResourceReference<inkHudEntriesResource>>(value);
		}

		public inkHUDLayerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
