using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("wasImmediateChange")] 
		public CBool WasImmediateChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DoorReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
