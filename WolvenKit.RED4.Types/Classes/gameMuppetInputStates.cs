using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputStates : RedBaseClass
	{
		private netTime _replicationTime;

		[Ordinal(0)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetProperty(ref _replicationTime);
			set => SetProperty(ref _replicationTime, value);
		}
	}
}
