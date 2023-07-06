using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeSingleSharedVarDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("sharedVarName")] 
		public LibTreeSharedVarRegistrationName SharedVarName
		{
			get => GetPropertyValue<LibTreeSharedVarRegistrationName>();
			set => SetPropertyValue<LibTreeSharedVarRegistrationName>(value);
		}

		public AICTreeNodeSingleSharedVarDecoratorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
