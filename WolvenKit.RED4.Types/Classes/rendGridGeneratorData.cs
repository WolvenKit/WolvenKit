using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendGridGeneratorData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startingPosition")] 
		public Vector3 StartingPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public EulerAngles Rotation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(2)] 
		[RED("xStep")] 
		public CFloat XStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("yStep")] 
		public CFloat YStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("numberOfXSteps")] 
		public CUInt32 NumberOfXSteps
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("numberOfYSteps")] 
		public CUInt32 NumberOfYSteps
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("orbitDistance")] 
		public CFloat OrbitDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("zoom")] 
		public CFloat Zoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public rendGridGeneratorData()
		{
			StartingPosition = new() { Z = 50.000000F };
			Rotation = new();
			XStep = 88.900002F;
			YStep = 50.000000F;
			NumberOfXSteps = 10;
			NumberOfYSteps = 10;
			OrbitDistance = 1.000000F;
			Zoom = 50.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
