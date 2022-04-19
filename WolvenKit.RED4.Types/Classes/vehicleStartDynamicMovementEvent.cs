using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleStartDynamicMovementEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public vehicleStartDynamicMovementEvent()
		{
			TargetPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
