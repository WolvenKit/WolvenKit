using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITreeArgumentsDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("args")] 
		public CArray<CHandle<AIArgumentDefinition>> Args
		{
			get => GetPropertyValue<CArray<CHandle<AIArgumentDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<AIArgumentDefinition>>>(value);
		}

		public AITreeArgumentsDefinition()
		{
			Args = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
