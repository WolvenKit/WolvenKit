using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("limit")] 
		public LibTreeDefInt32 Limit
		{
			get => GetPropertyValue<LibTreeDefInt32>();
			set => SetPropertyValue<LibTreeDefInt32>(value);
		}

		public AITreeNodeRepeatDefinition()
		{
			Limit = new() { VariableId = 65535 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
