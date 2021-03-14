using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HudPhoneMessageController : HUDPhoneElement
	{
		private inkTextWidgetReference _messageText;
		private CHandle<inkanimProxy> _messageAnim;
		private CName _showingAnimationName;
		private CName _hidingAnimationName;
		private CName _visibleAnimationName;
		private CInt32 _messageMaxLength;
		private CString _messageTopper;
		private CBool _paused;
		private wCHandle<gameJournalPhoneMessage> _currentMessage;
		private CArray<wCHandle<gameJournalPhoneMessage>> _queue;

		[Ordinal(2)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get
			{
				if (_messageText == null)
				{
					_messageText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "MessageText", cr2w, this);
				}
				return _messageText;
			}
			set
			{
				if (_messageText == value)
				{
					return;
				}
				_messageText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("MessageAnim")] 
		public CHandle<inkanimProxy> MessageAnim
		{
			get
			{
				if (_messageAnim == null)
				{
					_messageAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "MessageAnim", cr2w, this);
				}
				return _messageAnim;
			}
			set
			{
				if (_messageAnim == value)
				{
					return;
				}
				_messageAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ShowingAnimationName")] 
		public CName ShowingAnimationName
		{
			get
			{
				if (_showingAnimationName == null)
				{
					_showingAnimationName = (CName) CR2WTypeManager.Create("CName", "ShowingAnimationName", cr2w, this);
				}
				return _showingAnimationName;
			}
			set
			{
				if (_showingAnimationName == value)
				{
					return;
				}
				_showingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HidingAnimationName")] 
		public CName HidingAnimationName
		{
			get
			{
				if (_hidingAnimationName == null)
				{
					_hidingAnimationName = (CName) CR2WTypeManager.Create("CName", "HidingAnimationName", cr2w, this);
				}
				return _hidingAnimationName;
			}
			set
			{
				if (_hidingAnimationName == value)
				{
					return;
				}
				_hidingAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("VisibleAnimationName")] 
		public CName VisibleAnimationName
		{
			get
			{
				if (_visibleAnimationName == null)
				{
					_visibleAnimationName = (CName) CR2WTypeManager.Create("CName", "VisibleAnimationName", cr2w, this);
				}
				return _visibleAnimationName;
			}
			set
			{
				if (_visibleAnimationName == value)
				{
					return;
				}
				_visibleAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("MessageMaxLength")] 
		public CInt32 MessageMaxLength
		{
			get
			{
				if (_messageMaxLength == null)
				{
					_messageMaxLength = (CInt32) CR2WTypeManager.Create("Int32", "MessageMaxLength", cr2w, this);
				}
				return _messageMaxLength;
			}
			set
			{
				if (_messageMaxLength == value)
				{
					return;
				}
				_messageMaxLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("MessageTopper")] 
		public CString MessageTopper
		{
			get
			{
				if (_messageTopper == null)
				{
					_messageTopper = (CString) CR2WTypeManager.Create("String", "MessageTopper", cr2w, this);
				}
				return _messageTopper;
			}
			set
			{
				if (_messageTopper == value)
				{
					return;
				}
				_messageTopper = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Paused")] 
		public CBool Paused
		{
			get
			{
				if (_paused == null)
				{
					_paused = (CBool) CR2WTypeManager.Create("Bool", "Paused", cr2w, this);
				}
				return _paused;
			}
			set
			{
				if (_paused == value)
				{
					return;
				}
				_paused = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("CurrentMessage")] 
		public wCHandle<gameJournalPhoneMessage> CurrentMessage
		{
			get
			{
				if (_currentMessage == null)
				{
					_currentMessage = (wCHandle<gameJournalPhoneMessage>) CR2WTypeManager.Create("whandle:gameJournalPhoneMessage", "CurrentMessage", cr2w, this);
				}
				return _currentMessage;
			}
			set
			{
				if (_currentMessage == value)
				{
					return;
				}
				_currentMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Queue")] 
		public CArray<wCHandle<gameJournalPhoneMessage>> Queue
		{
			get
			{
				if (_queue == null)
				{
					_queue = (CArray<wCHandle<gameJournalPhoneMessage>>) CR2WTypeManager.Create("array:whandle:gameJournalPhoneMessage", "Queue", cr2w, this);
				}
				return _queue;
			}
			set
			{
				if (_queue == value)
				{
					return;
				}
				_queue = value;
				PropertySet(this);
			}
		}

		public HudPhoneMessageController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
