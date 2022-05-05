using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class moveSecureFootingResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slidingDirection")] 
		public Vector4 SlidingDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("normalDirection")] 
		public Vector4 NormalDirection
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("lowestLocalPosition")] 
		public Vector4 LowestLocalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("staticGroundFactor")] 
		public CFloat StaticGroundFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("reason")] 
		public CEnum<moveSecureFootingFailureReason> Reason
		{
			get => GetPropertyValue<CEnum<moveSecureFootingFailureReason>>();
			set => SetPropertyValue<CEnum<moveSecureFootingFailureReason>>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<moveSecureFootingFailureType> Type
		{
			get => GetPropertyValue<CEnum<moveSecureFootingFailureType>>();
			set => SetPropertyValue<CEnum<moveSecureFootingFailureType>>(value);
		}

		public moveSecureFootingResult()
		{
			SlidingDirection = new();
			NormalDirection = new();
			LowestLocalPosition = new();
			StaticGroundFactor = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
