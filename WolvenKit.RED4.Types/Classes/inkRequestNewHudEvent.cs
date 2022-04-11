using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkRequestNewHudEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entriesResource")] 
		public CResourceReference<inkHudEntriesResource> EntriesResource
		{
			get => GetPropertyValue<CResourceReference<inkHudEntriesResource>>();
			set => SetPropertyValue<CResourceReference<inkHudEntriesResource>>(value);
		}
	}
}
