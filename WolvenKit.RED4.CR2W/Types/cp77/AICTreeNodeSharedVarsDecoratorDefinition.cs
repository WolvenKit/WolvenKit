using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		private AISharedVarTableDefinition _sharedVars;

		[Ordinal(1)] 
		[RED("sharedVars")] 
		public AISharedVarTableDefinition SharedVars
		{
			get => GetProperty(ref _sharedVars);
			set => SetProperty(ref _sharedVars, value);
		}

		public AICTreeNodeSharedVarsDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
