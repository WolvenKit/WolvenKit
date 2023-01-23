using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_RotateOnAxis : gameTransformAnimationTrackItemImpl
	{
		[Ordinal(0)] 
		[RED("axis")] 
		public CEnum<gameTransformAnimation_RotateOnAxisAxis> Axis
		{
			get => GetPropertyValue<CEnum<gameTransformAnimation_RotateOnAxisAxis>>();
			set => SetPropertyValue<CEnum<gameTransformAnimation_RotateOnAxisAxis>>(value);
		}

		[Ordinal(1)] 
		[RED("numberOfFullRotations")] 
		public CFloat NumberOfFullRotations
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetPropertyValue<CHandle<gameTransformAnimation_Movement>>();
			set => SetPropertyValue<CHandle<gameTransformAnimation_Movement>>(value);
		}

		public gameTransformAnimation_RotateOnAxis()
		{
			Axis = Enums.gameTransformAnimation_RotateOnAxisAxis.Z;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
