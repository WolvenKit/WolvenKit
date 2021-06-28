using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		private CUInt32 _highLevelCbId;
		private CUInt32 _delayEvaluationCbId;

		[Ordinal(0)] 
		[RED("highLevelCbId")] 
		public CUInt32 HighLevelCbId
		{
			get => GetProperty(ref _highLevelCbId);
			set => SetProperty(ref _highLevelCbId, value);
		}

		[Ordinal(1)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetProperty(ref _delayEvaluationCbId);
			set => SetProperty(ref _delayEvaluationCbId, value);
		}

		public PassiveAlertedConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
