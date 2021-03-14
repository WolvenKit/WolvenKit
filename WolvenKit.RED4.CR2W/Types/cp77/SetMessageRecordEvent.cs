using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetMessageRecordEvent : redEvent
	{
		private TweakDBID _messageRecordID;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(0)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get
			{
				if (_messageRecordID == null)
				{
					_messageRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "messageRecordID", cr2w, this);
				}
				return _messageRecordID;
			}
			set
			{
				if (_messageRecordID == value)
				{
					return;
				}
				_messageRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get
			{
				if (_replaceTextWithCustomNumber == null)
				{
					_replaceTextWithCustomNumber = (CBool) CR2WTypeManager.Create("Bool", "replaceTextWithCustomNumber", cr2w, this);
				}
				return _replaceTextWithCustomNumber;
			}
			set
			{
				if (_replaceTextWithCustomNumber == value)
				{
					return;
				}
				_replaceTextWithCustomNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get
			{
				if (_customNumber == null)
				{
					_customNumber = (CInt32) CR2WTypeManager.Create("Int32", "customNumber", cr2w, this);
				}
				return _customNumber;
			}
			set
			{
				if (_customNumber == value)
				{
					return;
				}
				_customNumber = value;
				PropertySet(this);
			}
		}

		public SetMessageRecordEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
