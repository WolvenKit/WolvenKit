using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeIncludedTreeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] [RED("tree")] public LibTreeDefTree Tree { get; set; }

		public AICTreeNodeIncludedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
