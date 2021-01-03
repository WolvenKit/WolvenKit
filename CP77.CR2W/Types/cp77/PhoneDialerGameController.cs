using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhoneDialerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("audioPhoneNavigation")] public CName AudioPhoneNavigation { get; set; }
		[Ordinal(2)]  [RED("avatarImage")] public inkImageWidgetReference AvatarImage { get; set; }
		[Ordinal(3)]  [RED("contactOpensBBID")] public CUInt32 ContactOpensBBID { get; set; }
		[Ordinal(4)]  [RED("contactsList")] public inkWidgetReference ContactsList { get; set; }
		[Ordinal(5)]  [RED("dataSource")] public CHandle<inkScriptableDataSourceWrapper> DataSource { get; set; }
		[Ordinal(6)]  [RED("dataView")] public CHandle<DialerContactDataView> DataView { get; set; }
		[Ordinal(7)]  [RED("hintMessenger")] public inkWidgetReference HintMessenger { get; set; }
		[Ordinal(8)]  [RED("journalManager")] public CHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(9)]  [RED("listController")] public wCHandle<inkVirtualListController> ListController { get; set; }
		[Ordinal(10)]  [RED("phoneBBDefinition")] public CHandle<UI_ComDeviceDef> PhoneBBDefinition { get; set; }
		[Ordinal(11)]  [RED("phoneBlackboard")] public CHandle<gameIBlackboard> PhoneBlackboard { get; set; }
		[Ordinal(12)]  [RED("phoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }
		[Ordinal(13)]  [RED("scrollArea")] public inkScrollAreaWidgetReference ScrollArea { get; set; }
		[Ordinal(14)]  [RED("scrollController")] public wCHandle<inkScrollController> ScrollController { get; set; }
		[Ordinal(15)]  [RED("scrollControllerWidget")] public inkWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(16)]  [RED("soundName")] public CName SoundName { get; set; }
		[Ordinal(17)]  [RED("switchAnimProxy")] public CHandle<inkanimProxy> SwitchAnimProxy { get; set; }
		[Ordinal(18)]  [RED("templateClassifier")] public CHandle<DialerContactTemplateClassifier> TemplateClassifier { get; set; }
		[Ordinal(19)]  [RED("transitionAnimProxy")] public CHandle<inkanimProxy> TransitionAnimProxy { get; set; }

		public PhoneDialerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
