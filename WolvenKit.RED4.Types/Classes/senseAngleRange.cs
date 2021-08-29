using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseAngleRange : senseIShape
	{
		private Vector4 _position;
		private CFloat _angle;
		private CFloat _range;
		private CFloat _halfHeight;

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(3)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(4)] 
		[RED("halfHeight")] 
		public CFloat HalfHeight
		{
			get => GetProperty(ref _halfHeight);
			set => SetProperty(ref _halfHeight, value);
		}
	}
}
