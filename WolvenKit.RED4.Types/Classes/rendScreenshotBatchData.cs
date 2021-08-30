using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendScreenshotBatchData : RedBaseClass
	{
		private AbsolutePathSerializable _batchPositionsPath;
		private CFloat _delayTime;
		private CUInt32 _numberOfCoordinatesToDump;

		[Ordinal(0)] 
		[RED("batchPositionsPath")] 
		public AbsolutePathSerializable BatchPositionsPath
		{
			get => GetProperty(ref _batchPositionsPath);
			set => SetProperty(ref _batchPositionsPath, value);
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		[Ordinal(2)] 
		[RED("numberOfCoordinatesToDump")] 
		public CUInt32 NumberOfCoordinatesToDump
		{
			get => GetProperty(ref _numberOfCoordinatesToDump);
			set => SetProperty(ref _numberOfCoordinatesToDump, value);
		}

		public rendScreenshotBatchData()
		{
			_delayTime = 1.000000F;
		}
	}
}
