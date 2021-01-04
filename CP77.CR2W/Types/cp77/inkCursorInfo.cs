using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCursorInfo : inkUserData
	{
		[Ordinal(0)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(1)]  [RED("pos")] public Vector2 Pos { get; set; }

		public inkCursorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
