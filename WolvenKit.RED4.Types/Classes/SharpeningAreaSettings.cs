using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SharpeningAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("sharpeningStrength")] 
		public CFloat SharpeningStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SharpeningAreaSettings()
		{
			Enable = true;
		}
	}
}
