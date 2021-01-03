using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedataValueNode : gamedataDataNode
	{
		[Ordinal(0)]  [RED("data")] public CHandle<gamedataValueDataNode> Data { get; set; }
		[Ordinal(1)]  [RED("group")] public CHandle<gamedataGroupNode> Group { get; set; }

		public gamedataValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
