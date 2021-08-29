using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private AISharedVarTableDefinition _sharedVars;

		[Ordinal(1)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get => GetProperty(ref _sharedVars);
			set => SetProperty(ref _sharedVars, value);
		}
	}
}
