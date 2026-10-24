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
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };
			MaxSpeed = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			MinSpeed = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			ClearTrafficOnPath = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			EmergencyPatrol = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			NumPatrolLoops = new AIArgumentMapping { Type = Enums.AIArgumentType.Uint64, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Uint64" };
			ForcedStartSpeed = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
