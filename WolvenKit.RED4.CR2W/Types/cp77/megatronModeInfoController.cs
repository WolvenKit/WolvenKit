using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronModeInfoController : TriggerModeLogicController
	{
		[Ordinal(1)] [RED("ammoBarVisibility")] public wCHandle<inkWidget> AmmoBarVisibility { get; set; }
		[Ordinal(2)] [RED("chargeBarVisibility")] public wCHandle<inkWidget> ChargeBarVisibility { get; set; }
		[Ordinal(3)] [RED("fullAutoModeText")] public wCHandle<inkWidget> FullAutoModeText { get; set; }
		[Ordinal(4)] [RED("chargeModeText")] public wCHandle<inkWidget> ChargeModeText { get; set; }
		[Ordinal(5)] [RED("fullAutoModeBG")] public wCHandle<inkWidget> FullAutoModeBG { get; set; }
		[Ordinal(6)] [RED("chargeModeBG")] public wCHandle<inkWidget> ChargeModeBG { get; set; }
		[Ordinal(7)] [RED("bg1")] public wCHandle<inkWidget> Bg1 { get; set; }
		[Ordinal(8)] [RED("bg2")] public wCHandle<inkWidget> Bg2 { get; set; }
		[Ordinal(9)] [RED("vignette")] public wCHandle<inkWidget> Vignette { get; set; }

		public megatronModeInfoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
