using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FramePS : gameObjectPS
	{
		[Ordinal(0)] 
		[RED("screenshotHash")] 
		public CUInt32 ScreenshotHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("screenshotID")] 
		public CInt32 ScreenshotID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("screenshotUVLeft")] 
		public CFloat ScreenshotUVLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("screenshotUVRight")] 
		public CFloat ScreenshotUVRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("screenshotUVTop")] 
		public CFloat ScreenshotUVTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("screenshotUVBottom")] 
		public CFloat ScreenshotUVBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FramePS()
		{
			ScreenshotID = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
