
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRearWheelsFrictionModifier_Record
	{
		[RED("maxHelperAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxHelperAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxLatSlipRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLatSlipRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxLongSlipRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLongSlipRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLatFrictionCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLatFrictionCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLatSlipRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLatSlipRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLongFrictionCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLongFrictionCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minLongSlipRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinLongSlipRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
