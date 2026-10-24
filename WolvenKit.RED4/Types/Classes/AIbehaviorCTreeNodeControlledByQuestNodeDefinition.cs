
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCTreeNodeControlledByQuestNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorCTreeNodeControlledByQuestNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
