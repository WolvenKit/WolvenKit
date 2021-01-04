using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HotkeysWidgetController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("car")] public wCHandle<inkWidget> Car { get; set; }
		[Ordinal(1)]  [RED("consumables")] public wCHandle<inkWidget> Consumables { get; set; }
		[Ordinal(2)]  [RED("fact1ListenerId")] public CUInt32 Fact1ListenerId { get; set; }
		[Ordinal(3)]  [RED("fact2ListenerId")] public CUInt32 Fact2ListenerId { get; set; }
		[Ordinal(4)]  [RED("gadgets")] public wCHandle<inkWidget> Gadgets { get; set; }
		[Ordinal(5)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(6)]  [RED("hotkeysList")] public inkHorizontalPanelWidgetReference HotkeysList { get; set; }
		[Ordinal(7)]  [RED("phone")] public wCHandle<inkWidget> Phone { get; set; }
		[Ordinal(8)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(9)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(10)]  [RED("utilsList")] public inkHorizontalPanelWidgetReference UtilsList { get; set; }

		public HotkeysWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
