using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExposureCompensationAreaSettings : IAreaSettings
	{
		private CFloat _exposureCompensation;

		[Ordinal(2)] 
		[RED("exposureCompensation")] 
		public CFloat ExposureCompensation
		{
			get => GetProperty(ref _exposureCompensation);
			set => SetProperty(ref _exposureCompensation, value);
		}
	}
}
