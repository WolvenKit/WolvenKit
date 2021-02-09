using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Tech_Omaha : gameuiCrosshairBaseGameController
	{
		[Ordinal(16)]  [RED("leftPart")] public wCHandle<inkWidget> LeftPart { get; set; }
		[Ordinal(17)]  [RED("rightPart")] public wCHandle<inkWidget> RightPart { get; set; }
		[Ordinal(18)]  [RED("topPart")] public wCHandle<inkWidget> TopPart { get; set; }
		[Ordinal(19)]  [RED("chargeBar")] public wCHandle<inkRectangleWidget> ChargeBar { get; set; }
		[Ordinal(20)]  [RED("sizeOfChargeBar")] public Vector2 SizeOfChargeBar { get; set; }
		[Ordinal(21)]  [RED("chargeBBID")] public CUInt32 ChargeBBID { get; set; }

		public Crosshair_Tech_Omaha(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
