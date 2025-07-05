
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAIVisionSettings_Record
	{
		[RED("maxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxStraightPathExtension")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxStraightPathExtension
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("numSweeps")]
		[REDProperty(IsIgnored = true)]
		public CInt32 NumSweeps
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("offsetSmoothingFastChangeSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat OffsetSmoothingFastChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("offsetSmoothingReturnToNeutralSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat OffsetSmoothingReturnToNeutralSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sideOverlapForwardOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat SideOverlapForwardOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sideOverlapLateralScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat SideOverlapLateralScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sideOverlapLongitudinalScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat SideOverlapLongitudinalScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speedLimitDeceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedLimitDeceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speedLimitSafetyMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedLimitSafetyMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useSpeedLimit")]
		[REDProperty(IsIgnored = true)]
		public CBool UseSpeedLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
