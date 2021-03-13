using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectMoverStatus : redEvent
	{
		[Ordinal(0)] [RED("ownerName")] public CName OwnerName { get; set; }
		[Ordinal(1)] [RED("direction")] public CEnum<EMovementDirection> Direction { get; set; }

		public ObjectMoverStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
