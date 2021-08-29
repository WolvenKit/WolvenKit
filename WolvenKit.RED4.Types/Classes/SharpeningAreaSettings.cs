using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SharpeningAreaSettings : IAreaSettings
	{
		private CFloat _sharpeningStrength;

		[Ordinal(2)] 
		[RED("sharpeningStrength")] 
		public CFloat SharpeningStrength
		{
			get => GetProperty(ref _sharpeningStrength);
			set => SetProperty(ref _sharpeningStrength, value);
		}
	}
}
