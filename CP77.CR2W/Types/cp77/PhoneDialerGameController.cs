using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneDialerGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("contactsList")] public inkWidgetReference ContactsList { get; set; }
		[Ordinal(8)]  [RED("avatarImage")] public inkImageWidgetReference AvatarImage { get; set; }
		[Ordinal(9)]  [RED("hintMessenger")] public inkWidgetReference HintMessenger { get; set; }
		[Ordinal(10)]  [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(11)]  [RED("scrollControllerWidget")] public inkWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(12)]  [RED("journalManager")] public CHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(13)]  [RED("phoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }
		[Ordinal(14)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(15)]  [RED("listController")] public wCHandle<inkVirtualListController> ListController { get; set; }
		[Ordinal(16)]  [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(17)]  [RED("dataView")] public CHandle<DialerContactDataView> DataView { get; set; }
		[Ordinal(18)]  [RED("templateClassifier")] public CHandle<DialerContactTemplateClassifier> TemplateClassifier { get; set; }
		[Ordinal(19)]  [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }
		[Ordinal(20)]  [RED("soundName")] public CName SoundName { get; set; }
		[Ordinal(21)]  [RED("audioPhoneNavigation")] public CName AudioPhoneNavigation { get; set; }
		[Ordinal(22)]  [RED("phoneBlackboard")] public wCHandle<gameIBlackboard> PhoneBlackboard { get; set; }
		[Ordinal(23)]  [RED("phoneBBDefinition")] public CHandle<UI_ComDeviceDef> PhoneBBDefinition { get; set; }
		[Ordinal(24)]  [RED("contactOpensBBID")] public CUInt32 ContactOpensBBID { get; set; }
		[Ordinal(25)]  [RED("switchAnimProxy")] public CHandle<inkanimProxy> SwitchAnimProxy { get; set; }
		[Ordinal(26)]  [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }

		public PhoneDialerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
