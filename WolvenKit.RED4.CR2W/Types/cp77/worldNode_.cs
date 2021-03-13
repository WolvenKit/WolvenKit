using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNode_ : ISerializable
	{
		[Ordinal(2)] [RED("isVisibleInGame")] public CBool IsVisibleInGame { get; set; }
		[Ordinal(3)] [RED("isHostOnly")] public CBool IsHostOnly { get; set; }

		public worldNode_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
