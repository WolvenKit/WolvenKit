using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionRotateBaseState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("keepUpdatingTarget")] 
		public CBool KeepUpdatingTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("useRotationTime")] 
		public CBool UseRotationTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameActionRotateBaseState()
		{
			RotationTime = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
