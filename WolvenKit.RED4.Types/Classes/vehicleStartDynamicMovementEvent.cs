using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleStartDynamicMovementEvent : redEvent
	{
		private Vector3 _targetPosition;

		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}
	}
}
