using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePingSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<gamePingEntry> _replicatedPingEntries;

		[Ordinal(0)] 
		[RED("replicatedPingEntries")] 
		public CArray<gamePingEntry> ReplicatedPingEntries
		{
			get => GetProperty(ref _replicatedPingEntries);
			set => SetProperty(ref _replicatedPingEntries, value);
		}
	}
}
