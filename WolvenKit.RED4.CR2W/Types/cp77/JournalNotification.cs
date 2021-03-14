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
			get
			{
				if (_interactionsBlackboard == null)
				{
					_interactionsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "interactionsBlackboard", cr2w, this);
				}
				return _interactionsBlackboard;
			}
			set
			{
				if (_interactionsBlackboard == value)
				{
					return;
				}
				_interactionsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bbListenerId")] 
		public CUInt32 BbListenerId
		{
			get
			{
				if (_bbListenerId == null)
				{
					_bbListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "bbListenerId", cr2w, this);
				}
				return _bbListenerId;
			}
			set
			{
				if (_bbListenerId == value)
				{
					return;
				}
				_bbListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("questNotificationData")] 
		public CHandle<gameuiQuestUpdateNotificationViewData> QuestNotificationData
		{
			get
			{
				if (_questNotificationData == null)
				{
					_questNotificationData = (CHandle<gameuiQuestUpdateNotificationViewData>) CR2WTypeManager.Create("handle:gameuiQuestUpdateNotificationViewData", "questNotificationData", cr2w, this);
				}
				return _questNotificationData;
			}
			set
			{
				if (_questNotificationData == value)
				{
					return;
				}
				_questNotificationData = value;
				PropertySet(this);
			}
		}

		public JournalNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
