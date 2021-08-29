using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkRequestNewHudEvent : redEvent
	{
		private CResourceReference<inkHudEntriesResource> _entriesResource;

		[Ordinal(0)] 
		[RED("entriesResource")] 
		public CResourceReference<inkHudEntriesResource> EntriesResource
		{
			get => GetProperty(ref _entriesResource);
			set => SetProperty(ref _entriesResource, value);
		}
	}
}
