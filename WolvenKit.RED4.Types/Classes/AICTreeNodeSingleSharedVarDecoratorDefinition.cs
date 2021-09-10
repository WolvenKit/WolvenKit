using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSingleSharedVarDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("sharedVarName")] 
		public LibTreeSharedVarRegistrationName SharedVarName
		{
			get => GetPropertyValue<LibTreeSharedVarRegistrationName>();
			set => SetPropertyValue<LibTreeSharedVarRegistrationName>(value);
		}
	}
}
