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

		public rendScreenshotBatchData()
		{
			BatchPositionsPath = new();
			DelayTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
