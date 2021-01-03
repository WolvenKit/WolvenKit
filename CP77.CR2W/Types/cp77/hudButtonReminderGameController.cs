using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class hudButtonReminderGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("Button1")] public inkCompoundWidgetReference Button1 { get; set; }
		[Ordinal(1)]  [RED("Button2")] public inkCompoundWidgetReference Button2 { get; set; }
		[Ordinal(2)]  [RED("Button3")] public inkCompoundWidgetReference Button3 { get; set; }
		[Ordinal(3)]  [RED("interactingWithDeviceBBID")] public CUInt32 InteractingWithDeviceBBID { get; set; }
		[Ordinal(4)]  [RED("uiHudButtonHelpBB")] public CHandle<gameIBlackboard> UiHudButtonHelpBB { get; set; }

		public hudButtonReminderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
