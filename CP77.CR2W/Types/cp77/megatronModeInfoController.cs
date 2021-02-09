using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class megatronModeInfoController : TriggerModeLogicController
	{
		[Ordinal(0)]  [RED("ammoBarVisibility")] public wCHandle<inkWidget> AmmoBarVisibility { get; set; }
		[Ordinal(1)]  [RED("chargeBarVisibility")] public wCHandle<inkWidget> ChargeBarVisibility { get; set; }
		[Ordinal(2)]  [RED("fullAutoModeText")] public wCHandle<inkWidget> FullAutoModeText { get; set; }
		[Ordinal(3)]  [RED("chargeModeText")] public wCHandle<inkWidget> ChargeModeText { get; set; }
		[Ordinal(4)]  [RED("fullAutoModeBG")] public wCHandle<inkWidget> FullAutoModeBG { get; set; }
		[Ordinal(5)]  [RED("chargeModeBG")] public wCHandle<inkWidget> ChargeModeBG { get; set; }
		[Ordinal(6)]  [RED("bg1")] public wCHandle<inkWidget> Bg1 { get; set; }
		[Ordinal(7)]  [RED("bg2")] public wCHandle<inkWidget> Bg2 { get; set; }
		[Ordinal(8)]  [RED("vignette")] public wCHandle<inkWidget> Vignette { get; set; }

		public megatronModeInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
