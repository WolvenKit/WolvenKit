using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
		private inkTextWidgetReference _messageText;
		private inkImageWidgetReference _avatar;
		private inkTextWidgetReference _descriptionText;
		private inkImageWidgetReference _mappinIcon;
		private inkWidgetReference _envelopIcon;
		private CHandle<gameIBlackboard> _interactionsBlackboard;
		private CUInt32 _bbListenerId;
		private CHandle<gameuiPhoneMessageNotificationViewData> _messageData;
		private CHandle<inkanimProxy> _animProxy;
		private CInt32 _textSizeLimit;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;

		[Ordinal(12)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(13)] 
		[RED("avatar")] 
		public inkImageWidgetReference Avatar
		{
			get => GetProperty(ref _avatar);
			set => SetProperty(ref _avatar, value);
		}

		[Ordinal(14)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(15)] 
		[RED("mappinIcon")] 
		public inkImageWidgetReference MappinIcon
		{
			get => GetProperty(ref _mappinIcon);
			set => SetProperty(ref _mappinIcon, value);
		}

		[Ordinal(16)] 
		[RED("envelopIcon")] 
		public inkWidgetReference EnvelopIcon
		{
			get => GetProperty(ref _envelopIcon);
			set => SetProperty(ref _envelopIcon, value);
		}

		[Ordinal(17)] 
		[RED("interactionsBlackboard")] 
		public CHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetProperty(ref _interactionsBlackboard);
			set => SetProperty(ref _interactionsBlackboard, value);
		}

		[Ordinal(18)] 
		[RED("bbListenerId")] 
		public CUInt32 BbListenerId
		{
			get => GetProperty(ref _bbListenerId);
			set => SetProperty(ref _bbListenerId, value);
		}

		[Ordinal(19)] 
		[RED("messageData")] 
		public CHandle<gameuiPhoneMessageNotificationViewData> MessageData
		{
			get => GetProperty(ref _messageData);
			set => SetProperty(ref _messageData, value);
		}

		[Ordinal(20)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(21)] 
		[RED("textSizeLimit")] 
		public CInt32 TextSizeLimit
		{
			get => GetProperty(ref _textSizeLimit);
			set => SetProperty(ref _textSizeLimit, value);
		}

		[Ordinal(22)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(23)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		public MessengerNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
