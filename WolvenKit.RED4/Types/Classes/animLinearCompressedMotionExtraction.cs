using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLinearCompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("rotFrames")] 
		public CArray<Quaternion> RotFrames
		{
			get => GetPropertyValue<CArray<Quaternion>>();
			set => SetPropertyValue<CArray<Quaternion>>(value);
		}

		[Ordinal(2)] 
		[RED("posFrames")] 
		public CArray<Vector3> PosFrames
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(3)] 
		[RED("rotTime")] 
		public CArray<CFloat> RotTime
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("posTime")] 
		public CArray<CFloat> PosTime
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public animLinearCompressedMotionExtraction()
		{
			Duration = 1.000000F;
			RotFrames = new();
			PosFrames = new();
			RotTime = new();
			PosTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
