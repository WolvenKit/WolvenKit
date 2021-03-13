using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSharedVarsDecoratorDefinition : AICTreeNodeSharedVarsBaseDecoratorDefinition
	{
		[Ordinal(1)] [RED("sharedVars")] public AISharedVarTableDefinition SharedVars { get; set; }

		public AICTreeNodeSharedVarsDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
