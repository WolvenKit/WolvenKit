using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class interactionWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("activeHubListenerId")] public CUInt32 ActiveHubListenerId { get; set; }
		[Ordinal(1)]  [RED("areContactsOpen")] public CBool AreContactsOpen { get; set; }
		[Ordinal(2)]  [RED("bb")] public CHandle<gameIBlackboard> Bb { get; set; }
		[Ordinal(3)]  [RED("bbInteraction")] public CHandle<gameIBlackboard> BbInteraction { get; set; }
		[Ordinal(4)]  [RED("bbInteractionDefinition")] public CHandle<UIInteractionsDef> BbInteractionDefinition { get; set; }
		[Ordinal(5)]  [RED("bbLastAttemptedChoiceCallbackId")] public CUInt32 BbLastAttemptedChoiceCallbackId { get; set; }
		[Ordinal(6)]  [RED("bbPlayerStateMachine")] public CHandle<gameIBlackboard> BbPlayerStateMachine { get; set; }
		[Ordinal(7)]  [RED("bbUIInteractionsDef")] public CHandle<UIInteractionsDef> BbUIInteractionsDef { get; set; }
		[Ordinal(8)]  [RED("contactsActiveListenerId")] public CUInt32 ContactsActiveListenerId { get; set; }
		[Ordinal(9)]  [RED("hasProgressBar")] public CBool HasProgressBar { get; set; }
		[Ordinal(10)]  [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(11)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(12)]  [RED("optionsList")] public wCHandle<inkHorizontalPanelWidget> OptionsList { get; set; }
		[Ordinal(13)]  [RED("progressBar")] public CHandle<DialogChoiceTimerController> ProgressBar { get; set; }
		[Ordinal(14)]  [RED("progressBarHolder")] public inkWidgetReference ProgressBarHolder { get; set; }
		[Ordinal(15)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(16)]  [RED("titleBorder")] public wCHandle<inkWidget> TitleBorder { get; set; }
		[Ordinal(17)]  [RED("titleLabel")] public wCHandle<inkTextWidget> TitleLabel { get; set; }
		[Ordinal(18)]  [RED("updateInteractionId")] public CUInt32 UpdateInteractionId { get; set; }
		[Ordinal(19)]  [RED("widgetsPool")] public CArray<wCHandle<inkWidget>> WidgetsPool { get; set; }

		public interactionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
