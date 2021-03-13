using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIResource : LibTreeCTreeResource
	{
		[Ordinal(2)] [RED("root")] public CHandle<AICTreeNodeDefinition> Root { get; set; }

		public AIResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
