using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScreenMessageData : IScriptable
	{
		private CHandle<gamedataScreenMessageData_Record> _messageRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(0)] 
		[RED("messageRecord")] 
		public CHandle<gamedataScreenMessageData_Record> MessageRecord
		{
			get
			{
				if (_messageRecord == null)
				{
					_messageRecord = (CHandle<gamedataScreenMessageData_Record>) CR2WTypeManager.Create("handle:gamedataScreenMessageData_Record", "messageRecord", cr2w, this);
				}
				return _messageRecord;
			}
			set
			{
				if (_messageRecord == value)
				{
					return;
				}
				_messageRecord = value;
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

		public ScreenMessageData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
