using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerUnauthorized : ActionBool
	{
		[Ordinal(25)] [RED("isLiftDoor")] public CBool IsLiftDoor { get; set; }

		public PlayerUnauthorized(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
