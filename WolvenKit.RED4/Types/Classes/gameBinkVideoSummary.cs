using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBinkVideoSummary : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentTimeMs")] 
		public CUInt32 CurrentTimeMs
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("totalTimeMs")] 
		public CUInt32 TotalTimeMs
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("currentFrame")] 
		public CUInt32 CurrentFrame
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("totalFrames")] 
		public CUInt32 TotalFrames
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("frameRate")] 
		public CUInt32 FrameRate
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameBinkVideoSummary()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
