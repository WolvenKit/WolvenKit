
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHandbrakeFrictionModifier_Record
	{
		[RED("additionalBrakeForLongUse")]
		[REDProperty(IsIgnored = true)]
		public CFloat AdditionalBrakeForLongUse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blendOutTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("postHandbrakeTractionBoost")]
		[REDProperty(IsIgnored = true)]
		public CFloat PostHandbrakeTractionBoost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rearWheelsLatFrictionCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat RearWheelsLatFrictionCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rearWheelsLongFrictionCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat RearWheelsLongFrictionCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
