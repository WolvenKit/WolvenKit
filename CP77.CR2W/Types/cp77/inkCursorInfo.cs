using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCursorInfo : inkUserData
	{
		[Ordinal(0)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(1)]  [RED("pos")] public Vector2 Pos { get; set; }

		public inkCursorInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
