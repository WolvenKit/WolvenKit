using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSingleSharedVarDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private LibTreeSharedVarRegistrationName _sharedVarName;

		[Ordinal(1)] 
		[RED("sharedVarName")] 
		public LibTreeSharedVarRegistrationName SharedVarName
		{
			get => GetProperty(ref _sharedVarName);
			set => SetProperty(ref _sharedVarName, value);
		}

		public AICTreeNodeSingleSharedVarDecoratorDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
