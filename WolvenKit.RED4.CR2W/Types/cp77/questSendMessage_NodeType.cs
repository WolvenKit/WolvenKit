using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSendMessage_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _msg;
		private CBool _sendNotification;

		[Ordinal(0)] 
		[RED("msg")] 
		public CHandle<gameJournalPath> Msg
		{
			get
			{
				if (_msg == null)
				{
					_msg = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "msg", cr2w, this);
				}
				return _msg;
			}
			set
			{
				if (_msg == value)
				{
					return;
				}
				_msg = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get
			{
				if (_sendNotification == null)
				{
					_sendNotification = (CBool) CR2WTypeManager.Create("Bool", "sendNotification", cr2w, this);
				}
				return _sendNotification;
			}
			set
			{
				if (_sendNotification == value)
				{
					return;
				}
				_sendNotification = value;
				PropertySet(this);
			}
		}

		public questSendMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
