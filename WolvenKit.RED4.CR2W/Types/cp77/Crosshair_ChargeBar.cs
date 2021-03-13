using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_ChargeBar : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("bar")] public inkWidgetReference Bar { get; set; }
		[Ordinal(19)] [RED("ammo")] public inkTextWidgetReference Ammo { get; set; }
		[Ordinal(20)] [RED("leftPart")] public wCHandle<inkWidget> LeftPart { get; set; }
		[Ordinal(21)] [RED("rightPart")] public wCHandle<inkWidget> RightPart { get; set; }
		[Ordinal(22)] [RED("topPart")] public wCHandle<inkWidget> TopPart { get; set; }
		[Ordinal(23)] [RED("chargeBar")] public wCHandle<inkRectangleWidget> ChargeBar { get; set; }
		[Ordinal(24)] [RED("sizeOfChargeBar")] public Vector2 SizeOfChargeBar { get; set; }
		[Ordinal(25)] [RED("chargeBBID")] public CUInt32 ChargeBBID { get; set; }

		public Crosshair_ChargeBar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
