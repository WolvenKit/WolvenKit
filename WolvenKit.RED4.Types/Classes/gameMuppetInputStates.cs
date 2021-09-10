using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputStates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameMuppetInputStates()
		{
			ReplicationTime = new();
		}
	}
}
