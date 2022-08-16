
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDynamicDownforceHelper_Record
	{
		[RED("maxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeedFactorAir")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeedFactorAir
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxSpeedFactorGround")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxSpeedFactorGround
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
