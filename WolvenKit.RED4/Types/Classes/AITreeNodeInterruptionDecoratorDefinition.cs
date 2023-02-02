using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITreeNodeInterruptionDecoratorDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("interruptions")] 
		public CArray<CHandle<AIInterruptionHandlerDefinition>> Interruptions
		{
			get => GetPropertyValue<CArray<CHandle<AIInterruptionHandlerDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIInterruptionHandlerDefinition>>>(value);
		}

		public AITreeNodeInterruptionDecoratorDefinition()
		{
			Interruptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
