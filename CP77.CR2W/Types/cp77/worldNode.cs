using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNode : ISerializable
	{
		[Ordinal(0)]  [RED("isHostOnly")] public CBool IsHostOnly { get; set; }
		[Ordinal(1)]  [RED("isVisibleInGame")] public CBool IsVisibleInGame { get; set; }

		public worldNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
