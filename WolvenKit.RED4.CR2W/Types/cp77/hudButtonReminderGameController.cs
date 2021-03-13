using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudButtonReminderGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("Button1")] public inkCompoundWidgetReference Button1 { get; set; }
		[Ordinal(10)] [RED("Button2")] public inkCompoundWidgetReference Button2 { get; set; }
		[Ordinal(11)] [RED("Button3")] public inkCompoundWidgetReference Button3 { get; set; }
		[Ordinal(12)] [RED("uiHudButtonHelpBB")] public CHandle<gameIBlackboard> UiHudButtonHelpBB { get; set; }
		[Ordinal(13)] [RED("interactingWithDeviceBBID")] public CUInt32 InteractingWithDeviceBBID { get; set; }

		public hudButtonReminderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
