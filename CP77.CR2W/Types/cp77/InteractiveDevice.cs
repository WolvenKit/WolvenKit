using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveDevice : Device
	{
		[Ordinal(77)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(78)]  [RED("interactionIndicator")] public CHandle<gameLightComponent> InteractionIndicator { get; set; }
		[Ordinal(79)]  [RED("disableAreaIndicatorID")] public gameDelayID DisableAreaIndicatorID { get; set; }
		[Ordinal(80)]  [RED("delayedUIRefreshID")] public gameDelayID DelayedUIRefreshID { get; set; }
		[Ordinal(81)]  [RED("isPlayerAround")] public CBool IsPlayerAround { get; set; }
		[Ordinal(82)]  [RED("disableAreaIndicatorDelayActive")] public CBool DisableAreaIndicatorDelayActive { get; set; }
		[Ordinal(83)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }

		public InteractiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
