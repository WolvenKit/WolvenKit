using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveDevice : Device
	{
		[Ordinal(86)] [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(87)] [RED("interactionIndicator")] public CHandle<gameLightComponent> InteractionIndicator { get; set; }
		[Ordinal(88)] [RED("disableAreaIndicatorID")] public gameDelayID DisableAreaIndicatorID { get; set; }
		[Ordinal(89)] [RED("delayedUIRefreshID")] public gameDelayID DelayedUIRefreshID { get; set; }
		[Ordinal(90)] [RED("isPlayerAround")] public CBool IsPlayerAround { get; set; }
		[Ordinal(91)] [RED("disableAreaIndicatorDelayActive")] public CBool DisableAreaIndicatorDelayActive { get; set; }
		[Ordinal(92)] [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }

		public InteractiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
