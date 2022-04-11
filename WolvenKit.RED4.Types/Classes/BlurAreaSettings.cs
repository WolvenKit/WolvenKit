using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BlurAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("circularBlurRadius")] 
		public CFloat CircularBlurRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BlurAreaSettings()
		{
			Enable = true;
		}
	}
}
