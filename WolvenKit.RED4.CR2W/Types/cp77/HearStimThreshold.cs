using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HearStimThreshold : AIbehaviorconditionScript
	{
		private CInt32 _thresholdNumber;

		[Ordinal(0)] 
		[RED("thresholdNumber")] 
		public CInt32 ThresholdNumber
		{
			get => GetProperty(ref _thresholdNumber);
			set => SetProperty(ref _thresholdNumber, value);
		}

		public HearStimThreshold(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
