using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionLook : gameIMuppetInputAction
	{
		[Ordinal(0)] [RED("rotation")] public Vector2 Rotation { get; set; }

		public gameMuppetInputActionLook(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
