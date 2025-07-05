using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiChangeCameraControlHintVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("movementVisible")] 
		public CBool MovementVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("rotationVisible")] 
		public CBool RotationVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiChangeCameraControlHintVisibilityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
