using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsMappinSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("mappinState")] 
		public CArray<gameNewMappinID> MappinState
		{
			get => GetPropertyValue<CArray<gameNewMappinID>>();
			set => SetPropertyValue<CArray<gameNewMappinID>>(value);
		}

		[Ordinal(1)] 
		[RED("mappinWithJournalState")] 
		public CArray<CUInt32> MappinWithJournalState
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public gamemappinsMappinSystemReplicatedState()
		{
			MappinState = new();
			MappinWithJournalState = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
