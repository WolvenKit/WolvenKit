using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWaitTimeASTCD : audioAudioStateTransitionConditionData
	{
		private CFloat _timeToWait;

		[Ordinal(1)] 
		[RED("timeToWait")] 
		public CFloat TimeToWait
		{
			get => GetProperty(ref _timeToWait);
			set => SetProperty(ref _timeToWait, value);
		}

		public audioWaitTimeASTCD(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
