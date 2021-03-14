using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataValueNode : gamedataDataNode
	{
		[Ordinal(3)] [RED("data")] public CHandle<gamedataValueDataNode> Data { get; set; }
		[Ordinal(4)] [RED("group")] public CHandle<gamedataGroupNode> Group { get; set; }

		public gamedataValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
