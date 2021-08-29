using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPaddingInterpolator : inkanimInterpolator
	{
		private inkMargin _startValue;
		private inkMargin _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public inkMargin StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public inkMargin EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}
	}
}
