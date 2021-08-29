using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimColorInterpolator : inkanimInterpolator
	{
		private HDRColor _startValue;
		private HDRColor _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public HDRColor StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public HDRColor EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}
	}
}
