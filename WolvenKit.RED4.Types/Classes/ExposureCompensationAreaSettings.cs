using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExposureCompensationAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("exposureCompensation")] 
		public CFloat ExposureCompensation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ExposureCompensationAreaSettings()
		{
			Enable = true;
		}
	}
}
