
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAIBoostSettings_Record
	{
		[RED("maxLatTractionBoost")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLatTractionBoost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxLongTractionBoost")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxLongTractionBoost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxTorqueBoost")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTorqueBoost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
