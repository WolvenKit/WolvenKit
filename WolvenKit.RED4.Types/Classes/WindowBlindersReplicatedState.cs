using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowBlindersReplicatedState : gameDeviceReplicatedState
	{
		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isTilted")] 
		public CBool IsTilted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WindowBlindersReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
