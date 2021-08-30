using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerDetector : gameObject
	{
		private CFloat _range;

		[Ordinal(40)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		public cpPlayerDetector()
		{
			_range = 10.000000F;
		}
	}
}
