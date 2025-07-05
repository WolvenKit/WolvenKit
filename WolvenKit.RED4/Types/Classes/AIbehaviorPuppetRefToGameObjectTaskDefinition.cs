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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
