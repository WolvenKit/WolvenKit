using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileLinearMovementEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameprojectileLinearMovementEvent()
		{
			TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
