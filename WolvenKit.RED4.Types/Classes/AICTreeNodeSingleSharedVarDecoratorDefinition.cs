using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeSingleSharedVarDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private LibTreeSharedVarRegistrationName _sharedVarName;

		[Ordinal(1)] 
		[RED("sharedVarName")] 
		public LibTreeSharedVarRegistrationName SharedVarName
		{
			get => GetProperty(ref _sharedVarName);
			set => SetProperty(ref _sharedVarName, value);
		}
	}
}
