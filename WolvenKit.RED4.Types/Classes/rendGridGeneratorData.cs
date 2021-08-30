using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendGridGeneratorData : RedBaseClass
	{
		private Vector3 _startingPosition;
		private EulerAngles _rotation;
		private CFloat _xStep;
		private CFloat _yStep;
		private CUInt32 _numberOfXSteps;
		private CUInt32 _numberOfYSteps;
		private CFloat _orbitDistance;
		private CFloat _zoom;

		[Ordinal(0)] 
		[RED("startingPosition")] 
		public Vector3 StartingPosition
		{
			get => GetProperty(ref _startingPosition);
			set => SetProperty(ref _startingPosition, value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public EulerAngles Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(2)] 
		[RED("xStep")] 
		public CFloat XStep
		{
			get => GetProperty(ref _xStep);
			set => SetProperty(ref _xStep, value);
		}

		[Ordinal(3)] 
		[RED("yStep")] 
		public CFloat YStep
		{
			get => GetProperty(ref _yStep);
			set => SetProperty(ref _yStep, value);
		}

		[Ordinal(4)] 
		[RED("numberOfXSteps")] 
		public CUInt32 NumberOfXSteps
		{
			get => GetProperty(ref _numberOfXSteps);
			set => SetProperty(ref _numberOfXSteps, value);
		}

		[Ordinal(5)] 
		[RED("numberOfYSteps")] 
		public CUInt32 NumberOfYSteps
		{
			get => GetProperty(ref _numberOfYSteps);
			set => SetProperty(ref _numberOfYSteps, value);
		}

		[Ordinal(6)] 
		[RED("orbitDistance")] 
		public CFloat OrbitDistance
		{
			get => GetProperty(ref _orbitDistance);
			set => SetProperty(ref _orbitDistance, value);
		}

		[Ordinal(7)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetProperty(ref _zoom);
			set => SetProperty(ref _zoom, value);
		}

		public rendGridGeneratorData()
		{
			_xStep = 88.900002F;
			_yStep = 50.000000F;
			_numberOfXSteps = 10;
			_numberOfYSteps = 10;
			_orbitDistance = 1.000000F;
			_zoom = 50.000000F;
		}
	}
}
