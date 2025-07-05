using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseLimitWeights : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("mid")] 
		public CFloat Mid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("poseTrackIndex")] 
		public CInt16 PoseTrackIndex
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animPoseLimitWeights()
		{
			Min = 1.000000F;
			Mid = 1.000000F;
			Max = 1.000000F;
			PoseTrackIndex = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
