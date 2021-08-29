using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimShapeBorderTransparencyInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}
	}
}
