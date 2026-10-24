using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorPuppetRefToGameObjectTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("puppetRef")] 
		public CHandle<AIArgumentMapping> PuppetRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorPuppetRefToGameObjectTaskDefinition()
		{
			PuppetRef = new AIArgumentMapping { Type = Enums.AIArgumentType.PuppetRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "gameEntityReference" };
			Result = new AIArgumentMapping { Type = Enums.AIArgumentType.Object, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "whandle:gameObject" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
