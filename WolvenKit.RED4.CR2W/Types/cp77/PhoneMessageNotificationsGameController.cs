using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		private CInt32 _maxMessageSize;
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _text;
		private inkTextWidgetReference _actionText;
		private CHandle<inkWidget> _actionPanel;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<JournalNotificationData> _data;

		[Ordinal(2)] 
		[RED("maxMessageSize")] 
		public CInt32 MaxMessageSize
		{
			get
			{
				if (_maxMessageSize == null)
				{
					_maxMessageSize = (CInt32) CR2WTypeManager.Create("Int32", "maxMessageSize", cr2w, this);
				}
				return _maxMessageSize;
			}
			set
			{
				if (_maxMessageSize == value)
				{
					return;
				}
				_maxMessageSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionText")] 
		public inkTextWidgetReference ActionText
		{
			get
			{
				if (_actionText == null)
				{
					_actionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "actionText", cr2w, this);
				}
				return _actionText;
			}
			set
			{
				if (_actionText == value)
				{
					return;
				}
				_actionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("actionPanel")] 
		public CHandle<inkWidget> ActionPanel
		{
			get
			{
				if (_actionPanel == null)
				{
					_actionPanel = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "actionPanel", cr2w, this);
				}
				return _actionPanel;
			}
			set
			{
				if (_actionPanel == value)
				{
					return;
				}
				_actionPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("data")] 
		public wCHandle<JournalNotificationData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<JournalNotificationData>) CR2WTypeManager.Create("whandle:JournalNotificationData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public PhoneMessageNotificationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
