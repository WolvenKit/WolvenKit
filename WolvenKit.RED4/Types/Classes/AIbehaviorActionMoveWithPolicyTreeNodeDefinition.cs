using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionMoveWithPolicyTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIbehaviorActionMoveWithPolicyTreeNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
