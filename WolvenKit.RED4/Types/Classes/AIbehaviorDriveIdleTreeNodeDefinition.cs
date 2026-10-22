
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorDriveIdleTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		public AIbehaviorDriveIdleTreeNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
