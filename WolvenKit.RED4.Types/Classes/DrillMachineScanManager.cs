using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillMachineScanManager : gameScriptableComponent
	{
		private CBool _ppStarting;
		private CBool _ppEnding;
		private CFloat _ppCurrentStartTime;
		private CInt32 _ppCurrentEndFrame;
		private CFloat _idleToScanTime;
		private CInt32 _ppOffFrameDelay;

		[Ordinal(5)] 
		[RED("ppStarting")] 
		public CBool PpStarting
		{
			get => GetProperty(ref _ppStarting);
			set => SetProperty(ref _ppStarting, value);
		}

		[Ordinal(6)] 
		[RED("ppEnding")] 
		public CBool PpEnding
		{
			get => GetProperty(ref _ppEnding);
			set => SetProperty(ref _ppEnding, value);
		}

		[Ordinal(7)] 
		[RED("ppCurrentStartTime")] 
		public CFloat PpCurrentStartTime
		{
			get => GetProperty(ref _ppCurrentStartTime);
			set => SetProperty(ref _ppCurrentStartTime, value);
		}

		[Ordinal(8)] 
		[RED("ppCurrentEndFrame")] 
		public CInt32 PpCurrentEndFrame
		{
			get => GetProperty(ref _ppCurrentEndFrame);
			set => SetProperty(ref _ppCurrentEndFrame, value);
		}

		[Ordinal(9)] 
		[RED("idleToScanTime")] 
		public CFloat IdleToScanTime
		{
			get => GetProperty(ref _idleToScanTime);
			set => SetProperty(ref _idleToScanTime, value);
		}

		[Ordinal(10)] 
		[RED("ppOffFrameDelay")] 
		public CInt32 PpOffFrameDelay
		{
			get => GetProperty(ref _ppOffFrameDelay);
			set => SetProperty(ref _ppOffFrameDelay, value);
		}
	}
}
