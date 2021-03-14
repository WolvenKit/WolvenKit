using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMountedObjectInfo : ISerializable
	{
		[Ordinal(0)] [RED("isFirst")] public CBool IsFirst { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("ref")] public gameEntityReference Ref { get; set; }
		[Ordinal(3)] [RED("onMount")] public CBool OnMount { get; set; }
		[Ordinal(4)] [RED("role")] public CEnum<gameMountingSlotRole> Role { get; set; }

		public questMountedObjectInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
