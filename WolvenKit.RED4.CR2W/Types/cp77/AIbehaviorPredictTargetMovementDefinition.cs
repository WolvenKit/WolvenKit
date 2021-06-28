using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPredictTargetMovementDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _timeInterval;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("timeInterval")] 
		public CHandle<AIArgumentMapping> TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(3)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		public AIbehaviorPredictTargetMovementDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
