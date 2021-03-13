using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecoratorDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] [RED("child")] public CHandle<LibTreeINodeDefinition> Child { get; set; }

		public AICTreeNodeDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
