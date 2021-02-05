using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HotkeysWidgetController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("hotkeysList")] public inkHorizontalPanelWidgetReference HotkeysList { get; set; }
		[Ordinal(8)]  [RED("utilsList")] public inkHorizontalPanelWidgetReference UtilsList { get; set; }
		[Ordinal(9)]  [RED("phone")] public wCHandle<inkWidget> Phone { get; set; }
		[Ordinal(10)]  [RED("car")] public wCHandle<inkWidget> Car { get; set; }
		[Ordinal(11)]  [RED("consumables")] public wCHandle<inkWidget> Consumables { get; set; }
		[Ordinal(12)]  [RED("gadgets")] public wCHandle<inkWidget> Gadgets { get; set; }
		[Ordinal(13)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(14)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(15)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(16)]  [RED("fact1ListenerId")] public CUInt32 Fact1ListenerId { get; set; }
		[Ordinal(17)]  [RED("fact2ListenerId")] public CUInt32 Fact2ListenerId { get; set; }

		public HotkeysWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
