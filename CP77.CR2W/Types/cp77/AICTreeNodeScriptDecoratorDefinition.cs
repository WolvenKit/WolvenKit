using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeScriptDecoratorDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(1)] [RED("script")] public CHandle<gameActionScript> Script { get; set; }
		[Ordinal(2)] [RED("scriptName")] public CName ScriptName { get; set; }

		public AICTreeNodeScriptDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
