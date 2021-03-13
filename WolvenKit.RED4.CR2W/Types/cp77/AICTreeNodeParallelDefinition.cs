using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeParallelDefinition : AICTreeNodeChildrenListDefinition
	{
		[Ordinal(1)] [RED("forwardChildrenCompleteness")] public CBool ForwardChildrenCompleteness { get; set; }

		public AICTreeNodeParallelDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
