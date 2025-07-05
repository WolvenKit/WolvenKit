using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMappinGPSDistance : questIDistance
	{
		[Ordinal(0)] 
		[RED("mappinPath")] 
		public CHandle<gameJournalPath> MappinPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		public questMappinGPSDistance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
