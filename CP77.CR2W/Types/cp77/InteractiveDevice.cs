using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractiveDevice : Device
	{
		[Ordinal(0)]  [RED("delayedUIRefreshID")] public gameDelayID DelayedUIRefreshID { get; set; }
		[Ordinal(1)]  [RED("disableAreaIndicatorDelayActive")] public CBool DisableAreaIndicatorDelayActive { get; set; }
		[Ordinal(2)]  [RED("disableAreaIndicatorID")] public gameDelayID DisableAreaIndicatorID { get; set; }
		[Ordinal(3)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(4)]  [RED("interactionIndicator")] public CHandle<gameLightComponent> InteractionIndicator { get; set; }
		[Ordinal(5)]  [RED("isPlayerAround")] public CBool IsPlayerAround { get; set; }
		[Ordinal(6)]  [RED("objectActionsCallbackCtrl")] public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }

		public InteractiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
