
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSmartGunMissParams_Record
	{
		[RED("areaToIgnoreHalfYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat AreaToIgnoreHalfYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Gravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxMissAnglePitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxMissAnglePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxMissAngleYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxMissAngleYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minMissAnglePitch")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinMissAnglePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minMissAngleYaw")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinMissAngleYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralCycleTimeMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralCycleTimeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralCycleTimeMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralCycleTimeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRampDownDistanceEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRampDownDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRampDownDistanceStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRampDownDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRampDownFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRampDownFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRampUpDistanceEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRampUpDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRampUpDistanceStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpiralRampUpDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spiralRandomizePhase")]
		[REDProperty(IsIgnored = true)]
		public CBool SpiralRandomizePhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
