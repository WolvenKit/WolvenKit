
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorNodeRefToObjectTaskDefinition : AIbehaviorNodeRefConverterTaskDefinition
	{
		public AIbehaviorNodeRefToObjectTaskDefinition()
		{
			NodeRef = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };
			Result = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
