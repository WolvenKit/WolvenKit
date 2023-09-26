using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendScreenshotBatchData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("batchPositionsPath")] 
		public AbsolutePathSerializable BatchPositionsPath
		{
			get => GetPropertyValue<AbsolutePathSerializable>();
			set => SetPropertyValue<AbsolutePathSerializable>(value);
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("numberOfCoordinatesToDump")] 
		public CUInt32 NumberOfCoordinatesToDump
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("mergeScreenshots")] 
		public CBool MergeScreenshots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("streamingObserverMode")] 
		public CEnum<rendEStreamingObserverMode> StreamingObserverMode
		{
			get => GetPropertyValue<CEnum<rendEStreamingObserverMode>>();
			set => SetPropertyValue<CEnum<rendEStreamingObserverMode>>(value);
		}

		public rendScreenshotBatchData()
		{
			BatchPositionsPath = new();
			DelayTime = 1.000000F;
			StreamingObserverMode = Enums.rendEStreamingObserverMode.Box;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
