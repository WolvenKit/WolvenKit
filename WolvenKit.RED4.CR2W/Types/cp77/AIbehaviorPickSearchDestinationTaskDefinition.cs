using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPickSearchDestinationTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _destinationPosition;
		private CHandle<AIArgumentMapping> _desiredDistance;
		private CHandle<AIArgumentMapping> _maxDistance;
		private CHandle<AIArgumentMapping> _clearedAreaRadius;
		private CHandle<AIArgumentMapping> _clearedAreaDistance;
		private CHandle<AIArgumentMapping> _clearedAreaAngle;
		private CHandle<AIArgumentMapping> _ignoreRestrictMovementArea;

		[Ordinal(1)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get => GetProperty(ref _destinationPosition);
			set => SetProperty(ref _destinationPosition, value);
		}

		[Ordinal(2)] 
		[RED("desiredDistance")] 
		public CHandle<AIArgumentMapping> DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CHandle<AIArgumentMapping> MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(4)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get => GetProperty(ref _clearedAreaRadius);
			set => SetProperty(ref _clearedAreaRadius, value);
		}

		[Ordinal(5)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get => GetProperty(ref _clearedAreaDistance);
			set => SetProperty(ref _clearedAreaDistance, value);
		}

		[Ordinal(6)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get => GetProperty(ref _clearedAreaAngle);
			set => SetProperty(ref _clearedAreaAngle, value);
		}

		[Ordinal(7)] 
		[RED("ignoreRestrictMovementArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea
		{
			get => GetProperty(ref _ignoreRestrictMovementArea);
			set => SetProperty(ref _ignoreRestrictMovementArea, value);
		}

		public AIbehaviorPickSearchDestinationTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
