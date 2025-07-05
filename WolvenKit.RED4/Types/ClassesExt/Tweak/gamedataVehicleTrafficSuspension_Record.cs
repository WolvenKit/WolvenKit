
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleTrafficSuspension_Record
	{
		[RED("latDampingRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat LatDampingRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("latPeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat LatPeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("longDampingRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat LongDampingRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("longPeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat LongPeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
