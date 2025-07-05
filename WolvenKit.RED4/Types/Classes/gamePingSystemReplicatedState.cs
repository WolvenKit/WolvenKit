using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePingSystemReplicatedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] 
		[RED("replicatedPingEntries")] 
		public CArray<gamePingEntry> ReplicatedPingEntries
		{
			get => GetPropertyValue<CArray<gamePingEntry>>();
			set => SetPropertyValue<CArray<gamePingEntry>>(value);
		}

		public gamePingSystemReplicatedState()
		{
			ReplicatedPingEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
