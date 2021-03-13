using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeTimeoutDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(1)] [RED("timeout")] public CFloat Timeout { get; set; }

		public AICTreeNodeTimeoutDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
