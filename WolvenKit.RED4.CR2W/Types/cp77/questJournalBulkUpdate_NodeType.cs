using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalBulkUpdate_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CName _requiredEntryType;
		private CName _requiredEntryState;
		private CName _newEntryState;
		private CBool _sendNotification;
		private CBool _propagateChange;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requiredEntryType")] 
		public CName RequiredEntryType
		{
			get
			{
				if (_requiredEntryType == null)
				{
					_requiredEntryType = (CName) CR2WTypeManager.Create("CName", "requiredEntryType", cr2w, this);
				}
				return _requiredEntryType;
			}
			set
			{
				if (_requiredEntryType == value)
				{
					return;
				}
				_requiredEntryType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requiredEntryState")] 
		public CName RequiredEntryState
		{
			get
			{
				if (_requiredEntryState == null)
				{
					_requiredEntryState = (CName) CR2WTypeManager.Create("CName", "requiredEntryState", cr2w, this);
				}
				return _requiredEntryState;
			}
			set
			{
				if (_requiredEntryState == value)
				{
					return;
				}
				_requiredEntryState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("newEntryState")] 
		public CName NewEntryState
		{
			get
			{
				if (_newEntryState == null)
				{
					_newEntryState = (CName) CR2WTypeManager.Create("CName", "newEntryState", cr2w, this);
				}
				return _newEntryState;
			}
			set
			{
				if (_newEntryState == value)
				{
					return;
				}
				_newEntryState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("propagateChange")] 
		public CBool PropagateChange
		{
			get
			{
				if (_propagateChange == null)
				{
					_propagateChange = (CBool) CR2WTypeManager.Create("Bool", "propagateChange", cr2w, this);
				}
				return _propagateChange;
			}
			set
			{
				if (_propagateChange == value)
				{
					return;
				}
				_propagateChange = value;
				PropertySet(this);
			}
		}

		public questJournalBulkUpdate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
