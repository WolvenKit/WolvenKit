using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthStimThresholdEvent : redEvent
	{
		private CBool _reset;
		private CFloat _timeThreshold;

		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(1)] 
		[RED("timeThreshold")] 
		public CFloat TimeThreshold
		{
			get => GetProperty(ref _timeThreshold);
			set => SetProperty(ref _timeThreshold, value);
		}

		public StealthStimThresholdEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
