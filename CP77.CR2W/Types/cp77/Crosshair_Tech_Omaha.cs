using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Tech_Omaha : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("leftPart")] public wCHandle<inkWidget> LeftPart { get; set; }
		[Ordinal(19)] [RED("rightPart")] public wCHandle<inkWidget> RightPart { get; set; }
		[Ordinal(20)] [RED("topPart")] public wCHandle<inkWidget> TopPart { get; set; }
		[Ordinal(21)] [RED("chargeBar")] public wCHandle<inkRectangleWidget> ChargeBar { get; set; }
		[Ordinal(22)] [RED("sizeOfChargeBar")] public Vector2 SizeOfChargeBar { get; set; }
		[Ordinal(23)] [RED("chargeBBID")] public CUInt32 ChargeBBID { get; set; }

		public Crosshair_Tech_Omaha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
