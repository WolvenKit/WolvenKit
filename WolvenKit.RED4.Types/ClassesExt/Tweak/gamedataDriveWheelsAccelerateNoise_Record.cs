
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDriveWheelsAccelerateNoise_Record
	{
		[RED("accelerationBoost")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationBoost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("accelerationBoostMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationBoostMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("accelerationBoostReverse")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationBoostReverse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("accelerationNoiseMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat AccelerationNoiseMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxApplyTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxApplyTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxForcesDifference")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxForcesDifference
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minApplyTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinApplyTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minForcesDifference")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinForcesDifference
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
