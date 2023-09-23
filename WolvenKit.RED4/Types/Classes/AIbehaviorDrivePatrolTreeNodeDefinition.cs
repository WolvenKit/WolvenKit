using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDrivePatrolTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("emergencyPatrol")] 
		public CHandle<AIArgumentMapping> EmergencyPatrol
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("numPatrolLoops")] 
		public CHandle<AIArgumentMapping> NumPatrolLoops
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorDrivePatrolTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
