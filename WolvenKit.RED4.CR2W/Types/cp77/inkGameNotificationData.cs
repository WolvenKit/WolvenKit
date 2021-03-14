using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameNotificationData : inkUserData
	{
		private CName _notificationName;
		private CBool _isBlocking;
		private CBool _useCursor;
		private CName _queueName;
		private CName _introAnimation;
		private wCHandle<inkGameNotificationToken> _token;

		[Ordinal(0)] 
		[RED("notificationName")] 
		public CName NotificationName
		{
			get
			{
				if (_notificationName == null)
				{
					_notificationName = (CName) CR2WTypeManager.Create("CName", "notificationName", cr2w, this);
				}
				return _notificationName;
			}
			set
			{
				if (_notificationName == value)
				{
					return;
				}
				_notificationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get
			{
				if (_isBlocking == null)
				{
					_isBlocking = (CBool) CR2WTypeManager.Create("Bool", "isBlocking", cr2w, this);
				}
				return _isBlocking;
			}
			set
			{
				if (_isBlocking == value)
				{
					return;
				}
				_isBlocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useCursor")] 
		public CBool UseCursor
		{
			get
			{
				if (_useCursor == null)
				{
					_useCursor = (CBool) CR2WTypeManager.Create("Bool", "useCursor", cr2w, this);
				}
				return _useCursor;
			}
			set
			{
				if (_useCursor == value)
				{
					return;
				}
				_useCursor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("queueName")] 
		public CName QueueName
		{
			get
			{
				if (_queueName == null)
				{
					_queueName = (CName) CR2WTypeManager.Create("CName", "queueName", cr2w, this);
				}
				return _queueName;
			}
			set
			{
				if (_queueName == value)
				{
					return;
				}
				_queueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get
			{
				if (_introAnimation == null)
				{
					_introAnimation = (CName) CR2WTypeManager.Create("CName", "introAnimation", cr2w, this);
				}
				return _introAnimation;
			}
			set
			{
				if (_introAnimation == value)
				{
					return;
				}
				_introAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("token")] 
		public wCHandle<inkGameNotificationToken> Token
		{
			get
			{
				if (_token == null)
				{
					_token = (wCHandle<inkGameNotificationToken>) CR2WTypeManager.Create("whandle:inkGameNotificationToken", "token", cr2w, this);
				}
				return _token;
			}
			set
			{
				if (_token == value)
				{
					return;
				}
				_token = value;
				PropertySet(this);
			}
		}

		public inkGameNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
