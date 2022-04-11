using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputStates : gameMuppetComponent
	{
		[Ordinal(3)] 
		[RED("replicationTime")] 
		public netTime ReplicationTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameMuppetInputStates()
		{
			Name = "Component";
			ReplicationTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
