using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsPieDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _center;
		private CFloat _baseLength;
		private CFloat _halfExtentZ;
		private CFloat _radius;
		private CFloat _angle;

		[Ordinal(0)] 
		[RED("center")] 
		public Vector4 Center
		{
			get => GetProperty(ref _center);
			set => SetProperty(ref _center, value);
		}

		[Ordinal(1)] 
		[RED("baseLength")] 
		public CFloat BaseLength
		{
			get => GetProperty(ref _baseLength);
			set => SetProperty(ref _baseLength, value);
		}

		[Ordinal(2)] 
		[RED("halfExtentZ")] 
		public CFloat HalfExtentZ
		{
			get => GetProperty(ref _halfExtentZ);
			set => SetProperty(ref _halfExtentZ, value);
		}

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(4)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}
	}
}
