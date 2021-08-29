using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FixedCapsule : RedBaseClass
	{
		private Vector4 _pointRadius;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("PointRadius")] 
		public Vector4 PointRadius
		{
			get => GetProperty(ref _pointRadius);
			set => SetProperty(ref _pointRadius, value);
		}

		[Ordinal(1)] 
		[RED("Height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}
	}
}
