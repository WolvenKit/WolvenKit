using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;
		private CEnum<questPhoneCallPhase> _phase;
		private CEnum<questPhoneCallMode> _mode;
		private NodeRef _prefabNodeRef;
		private CBool _applyPhoneRestriction;

		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get
			{
				if (_caller == null)
				{
					_caller = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "caller", cr2w, this);
				}
				return _caller;
			}
			set
			{
				if (_caller == value)
				{
					return;
				}
				_caller = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get
			{
				if (_addressee == null)
				{
					_addressee = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "addressee", cr2w, this);
				}
				return _addressee;
			}
			set
			{
				if (_addressee == value)
				{
					return;
				}
				_addressee = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("phase")] 
		public CEnum<questPhoneCallPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<questPhoneCallPhase>) CR2WTypeManager.Create("questPhoneCallPhase", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<questPhoneCallMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questPhoneCallMode>) CR2WTypeManager.Create("questPhoneCallMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get
			{
				if (_prefabNodeRef == null)
				{
					_prefabNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefabNodeRef", cr2w, this);
				}
				return _prefabNodeRef;
			}
			set
			{
				if (_prefabNodeRef == value)
				{
					return;
				}
				_prefabNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("applyPhoneRestriction")] 
		public CBool ApplyPhoneRestriction
		{
			get
			{
				if (_applyPhoneRestriction == null)
				{
					_applyPhoneRestriction = (CBool) CR2WTypeManager.Create("Bool", "applyPhoneRestriction", cr2w, this);
				}
				return _applyPhoneRestriction;
			}
			set
			{
				if (_applyPhoneRestriction == value)
				{
					return;
				}
				_applyPhoneRestriction = value;
				PropertySet(this);
			}
		}

		public questCallContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
