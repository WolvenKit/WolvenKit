
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleImpactTraffic_Record
	{
		[RED("maxThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxTimerStunned")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxTimerStunned
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
