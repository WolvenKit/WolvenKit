using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExposureCompensationOffsetAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("exposureCompensationOffset")] 
		public CFloat ExposureCompensationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ExposureCompensationOffsetAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
