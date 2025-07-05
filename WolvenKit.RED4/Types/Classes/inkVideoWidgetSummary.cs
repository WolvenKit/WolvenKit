using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkVideoWidgetSummary : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("currentTimeMs")] 
		public CUInt32 CurrentTimeMs
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("totalTimeMs")] 
		public CUInt32 TotalTimeMs
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("currentFrame")] 
		public CUInt32 CurrentFrame
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("totalFrames")] 
		public CUInt32 TotalFrames
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("frameRate")] 
		public CUInt32 FrameRate
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public inkVideoWidgetSummary()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
