using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHUDLayerDefinition : inkLayerDefinition
	{
		private CResourceReference<inkHudEntriesResource> _entriesResource;

		[Ordinal(8)] 
		[RED("entriesResource")] 
		public CResourceReference<inkHudEntriesResource> EntriesResource
		{
			get => GetProperty(ref _entriesResource);
			set => SetProperty(ref _entriesResource, value);
		}
	}
}
