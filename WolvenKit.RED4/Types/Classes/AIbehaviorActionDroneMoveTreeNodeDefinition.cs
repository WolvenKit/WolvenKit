using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionDroneMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("moveType")] 
		public CHandle<AIArgumentMapping> MoveType
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("movementTarget")] 
		public CHandle<AIArgumentMapping> MovementTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("toleranceRadius")] 
		public CHandle<AIArgumentMapping> ToleranceRadius
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("desiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> DesiredDistanceFromTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("strafingTarget")] 
		public CHandle<AIArgumentMapping> StrafingTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionDroneMoveTreeNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };
			MoveType = new AIArgumentMapping { Type = Enums.AIArgumentType.Enum, DefaultValue = new CVariant(), CustomTypeName = "moveMovementType" };
			Target = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };
			MovementTarget = new AIArgumentMapping { Type = Enums.AIArgumentType.Vector, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Vector3" };
			ToleranceRadius = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			DesiredDistanceFromTarget = new AIArgumentMapping { Type = Enums.AIArgumentType.Float, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "Float" };
			StrafingTarget = new AIArgumentMapping { Type = Enums.AIArgumentType.CName, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "CName" };
			StopWhenDestinationReached = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };
			RotateEntity = new AIArgumentMapping { ParameterizationType = Enums.AIParameterizationType.CustomValue, CustomTypeName = "Bool" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
