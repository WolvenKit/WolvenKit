
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNodeRefToInstanceTaskDefinition : AIbehaviorNodeRefConverterTaskDefinition
	{
		public AIbehaviorNodeRefToInstanceTaskDefinition()
		{
			NodeRef = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };
			Result = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
