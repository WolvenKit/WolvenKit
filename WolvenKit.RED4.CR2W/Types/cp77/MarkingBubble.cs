using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MarkingBubble : gameEffectExecutor_Scripted
	{
		private CFloat _delaySecondsPerMeterOfDistance;
		private CFloat _delayAdditionalRandomDelayMax;

		[Ordinal(1)] 
		[RED("delaySecondsPerMeterOfDistance")] 
		public CFloat DelaySecondsPerMeterOfDistance
		{
			get => GetProperty(ref _delaySecondsPerMeterOfDistance);
			set => SetProperty(ref _delaySecondsPerMeterOfDistance, value);
		}

		[Ordinal(2)] 
		[RED("delayAdditionalRandomDelayMax")] 
		public CFloat DelayAdditionalRandomDelayMax
		{
			get => GetProperty(ref _delayAdditionalRandomDelayMax);
			set => SetProperty(ref _delayAdditionalRandomDelayMax, value);
		}

		public MarkingBubble(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
