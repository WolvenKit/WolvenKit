using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSplineCompressedMotionExtraction : animIMotionExtraction
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("posKeysData")] 
		public CArray<CUInt8> PosKeysData
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(2)] 
		[RED("rotKeysData")] 
		public CArray<CUInt8> RotKeysData
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public animSplineCompressedMotionExtraction()
		{
			Duration = 1.000000F;
			PosKeysData = new();
			RotKeysData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
