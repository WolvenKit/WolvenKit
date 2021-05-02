using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsInDesiredRangeConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		private CHandle<AIArgumentMapping> _desiredDistance;
		private CHandle<AIArgumentMapping> _deadZoneRadius;

		[Ordinal(3)] 
		[RED("desiredDistance")] 
		public CHandle<AIArgumentMapping> DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(4)] 
		[RED("deadZoneRadius")] 
		public CHandle<AIArgumentMapping> DeadZoneRadius
		{
			get => GetProperty(ref _deadZoneRadius);
			set => SetProperty(ref _deadZoneRadius, value);
		}

		public AIbehaviorIsInDesiredRangeConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
