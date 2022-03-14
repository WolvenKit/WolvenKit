
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehiclePIDSettings_Record
	{
		[RED("D")]
		[REDProperty(IsIgnored = true)]
		public CFloat D
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("I")]
		[REDProperty(IsIgnored = true)]
		public CFloat I
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("integratorClampingLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat IntegratorClampingLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("outputSaturationLimit")]
		[REDProperty(IsIgnored = true)]
		public CFloat OutputSaturationLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("P")]
		[REDProperty(IsIgnored = true)]
		public CFloat P
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
