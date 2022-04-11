using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		[Ordinal(1)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get => GetPropertyValue<AISharedVarTableDefinition>();
			set => SetPropertyValue<AISharedVarTableDefinition>(value);
		}

		public AICTreeNodeSharedVarsDecoratorDefinition()
		{
			SharedVars = new() { Table = new() };
		}
	}
}
