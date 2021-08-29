using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Box : RedBaseClass
	{
		private Vector4 _min;
		private Vector4 _max;

		[Ordinal(0)] 
		[RED("Min")] 
		public Vector4 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("Max")] 
		public Vector4 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}
	}
}
