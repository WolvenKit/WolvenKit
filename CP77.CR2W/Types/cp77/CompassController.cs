using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CompassController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("faceLeft")] public inkWidgetReference FaceLeft { get; set; }
		[Ordinal(2)] [RED("faceRight")] public inkWidgetReference FaceRight { get; set; }
		[Ordinal(3)] [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(4)] [RED("decimalPrecision")] public CUInt32 DecimalPrecision { get; set; }
		[Ordinal(5)] [RED("faceRightStartPosition")] public Vector2 FaceRightStartPosition { get; set; }
		[Ordinal(6)] [RED("faceLeftStartPosition")] public Vector2 FaceLeftStartPosition { get; set; }
		[Ordinal(7)] [RED("isVertical")] public CBool IsVertical { get; set; }
		[Ordinal(8)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }

		public CompassController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
