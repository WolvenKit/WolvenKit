using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlurAreaSettings : IAreaSettings
	{
		private CFloat _circularBlurRadius;

		[Ordinal(2)] 
		[RED("circularBlurRadius")] 
		public CFloat CircularBlurRadius
		{
			get => GetProperty(ref _circularBlurRadius);
			set => SetProperty(ref _circularBlurRadius, value);
		}
	}
}
