using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalNotification : GenericNotificationController
	{
		private CHandle<gameIBlackboard> _interactionsBlackboard;
		private CUInt32 _bbListenerId;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<gameuiQuestUpdateNotificationViewData> _questNotificationData;

		[Ordinal(12)] 
		[RED("interactionsBlackboard")] 
		public CHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetProperty(ref _interactionsBlackboard);
			set => SetProperty(ref _interactionsBlackboard, value);
		}

		[Ordinal(13)] 
		[RED("bbListenerId")] 
		public CUInt32 BbListenerId
		{
			get => GetProperty(ref _bbListenerId);
			set => SetProperty(ref _bbListenerId, value);
		}

		[Ordinal(14)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(15)] 
		[RED("questNotificationData")] 
		public CHandle<gameuiQuestUpdateNotificationViewData> QuestNotificationData
		{
			get => GetProperty(ref _questNotificationData);
			set => SetProperty(ref _questNotificationData, value);
		}

		public JournalNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
