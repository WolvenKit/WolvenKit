using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_TriggerModeChange : animAnimFeature
	{
		private CFloat _cycleTime;

		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetProperty(ref _cycleTime);
			set => SetProperty(ref _cycleTime, value);
		}
	}
}
