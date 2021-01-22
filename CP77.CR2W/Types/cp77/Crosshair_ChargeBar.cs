using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_ChargeBar : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("ammo")] public inkTextWidgetReference Ammo { get; set; }
		[Ordinal(1)]  [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(2)]  [RED("chargeBBID")] public CUInt32 ChargeBBID { get; set; }
		[Ordinal(3)]  [RED("chargeBar")] public wCHandle<inkRectangleWidget> ChargeBar { get; set; }
		[Ordinal(4)]  [RED("leftPart")] public wCHandle<inkWidget> LeftPart { get; set; }
		[Ordinal(5)]  [RED("rightPart")] public wCHandle<inkWidget> RightPart { get; set; }
		[Ordinal(6)]  [RED("sizeOfChargeBar")] public Vector2 SizeOfChargeBar { get; set; }
		[Ordinal(7)]  [RED("topPart")] public wCHandle<inkWidget> TopPart { get; set; }

		public Crosshair_ChargeBar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
