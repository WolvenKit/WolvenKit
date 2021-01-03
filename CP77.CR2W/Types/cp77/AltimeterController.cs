using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AltimeterController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("decimalPrecision")] public CUInt32 DecimalPrecision { get; set; }
		[Ordinal(1)]  [RED("faceDown")] public inkWidgetReference FaceDown { get; set; }
		[Ordinal(2)]  [RED("faceDownStartPosition")] public Vector2 FaceDownStartPosition { get; set; }
		[Ordinal(3)]  [RED("faceUp")] public inkWidgetReference FaceUp { get; set; }
		[Ordinal(4)]  [RED("faceUpStartPosition")] public Vector2 FaceUpStartPosition { get; set; }
		[Ordinal(5)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(6)]  [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(7)]  [RED("warpDistance")] public CFloat WarpDistance { get; set; }

		public AltimeterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
