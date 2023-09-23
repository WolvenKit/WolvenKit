using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleRemoteControlEvent : gameActionEvent
	{
		[Ordinal(4)] 
		[RED("remoteControl")] 
		public CBool RemoteControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("shouldUnseatPassengers")] 
		public CBool ShouldUnseatPassengers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("shouldModifyInteractionState")] 
		public CBool ShouldModifyInteractionState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isDistanceDisconnect")] 
		public CBool IsDistanceDisconnect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleRemoteControlEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
