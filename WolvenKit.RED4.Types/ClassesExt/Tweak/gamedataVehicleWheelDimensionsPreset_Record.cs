
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelDimensionsPreset_Record
	{
		[RED("rimRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat RimRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tireRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat TireRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tireWidth")]
		[REDProperty(IsIgnored = true)]
		public CFloat TireWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("wheelOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat WheelOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
