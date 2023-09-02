using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workRandomList : workIContainerEntry
	{
		[Ordinal(4)] 
		[RED("minClips")] 
		public CInt8 MinClips
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(5)] 
		[RED("maxClips")] 
		public CInt8 MaxClips
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(6)] 
		[RED("pauseBetweenLength")] 
		public CFloat PauseBetweenLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("pauseLengthDeviation")] 
		public CFloat PauseLengthDeviation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("pauseBlendOutTime")] 
		public CFloat PauseBlendOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("dontRepeatLastAnims")] 
		public CInt8 DontRepeatLastAnims
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		public workRandomList()
		{
			Id = new workWorkEntryId { Id = uint.MaxValue };
			List = new();
			MinClips = 3;
			MaxClips = 5;
			PauseBetweenLength = 4.000000F;
			PauseLengthDeviation = 1.000000F;
			Weights = new();
			PauseBlendOutTime = 0.500000F;
			DontRepeatLastAnims = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
