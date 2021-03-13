using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeLazyNodeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] [RED("tree")] public CHandle<LibTreeCTreeResource> Tree { get; set; }

		public AICTreeLazyNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
