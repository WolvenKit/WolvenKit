using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DrillMachineScanManager : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("ppStarting")] 
		public CBool PpStarting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("ppEnding")] 
		public CBool PpEnding
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("ppCurrentStartTime")] 
		public CFloat PpCurrentStartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("ppCurrentEndFrame")] 
		public CInt32 PpCurrentEndFrame
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("idleToScanTime")] 
		public CFloat IdleToScanTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("ppOffFrameDelay")] 
		public CInt32 PpOffFrameDelay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public DrillMachineScanManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
