using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _clearedAreaRadius;
		private CHandle<AIArgumentMapping> _clearedAreaDistance;
		private CHandle<AIArgumentMapping> _clearedAreaAngle;

		[Ordinal(1)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get => GetProperty(ref _clearedAreaRadius);
			set => SetProperty(ref _clearedAreaRadius, value);
		}

		[Ordinal(2)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get => GetProperty(ref _clearedAreaDistance);
			set => SetProperty(ref _clearedAreaDistance, value);
		}

		[Ordinal(3)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get => GetProperty(ref _clearedAreaAngle);
			set => SetProperty(ref _clearedAreaAngle, value);
		}

		public AIbehaviorClearSearchInfluenceTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
