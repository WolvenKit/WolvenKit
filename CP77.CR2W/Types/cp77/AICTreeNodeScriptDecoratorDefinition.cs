using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeScriptDecoratorDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(0)]  [RED("script")] public CHandle<gameActionScript> Script { get; set; }
		[Ordinal(1)]  [RED("scriptName")] public CName ScriptName { get; set; }

		public AICTreeNodeScriptDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
