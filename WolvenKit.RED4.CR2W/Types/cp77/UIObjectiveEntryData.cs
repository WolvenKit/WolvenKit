using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIObjectiveEntryData : CVariable
	{
		private CString _name;
		private CString _counter;
		private CEnum<UIObjectiveEntryType> _type;
		private CEnum<gameJournalEntryState> _state;
		private CBool _isTracked;
		private CBool _isOptional;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("counter")] 
		public CString Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CString) CR2WTypeManager.Create("String", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<UIObjectiveEntryType>) CR2WTypeManager.Create("UIObjectiveEntryType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get
			{
				if (_isTracked == null)
				{
					_isTracked = (CBool) CR2WTypeManager.Create("Bool", "isTracked", cr2w, this);
				}
				return _isTracked;
			}
			set
			{
				if (_isTracked == value)
				{
					return;
				}
				_isTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get
			{
				if (_isOptional == null)
				{
					_isOptional = (CBool) CR2WTypeManager.Create("Bool", "isOptional", cr2w, this);
				}
				return _isOptional;
			}
			set
			{
				if (_isOptional == value)
				{
					return;
				}
				_isOptional = value;
				PropertySet(this);
			}
		}

		public UIObjectiveEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
