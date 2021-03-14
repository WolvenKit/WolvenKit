using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramData : CVariable
	{
		private CString _id;
		private CArray<CArray<ElementData>> _commandLists;
		private CArray<CEnum<ProgramEffect>> _effects;
		private CEnum<ProgramType> _type;
		private CString _localizationKey;
		private CBool _startAsUnknown;
		private CBool _wasCompleted;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CString) CR2WTypeManager.Create("String", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("commandLists")] 
		public CArray<CArray<ElementData>> CommandLists
		{
			get
			{
				if (_commandLists == null)
				{
					_commandLists = (CArray<CArray<ElementData>>) CR2WTypeManager.Create("array:array:ElementData", "commandLists", cr2w, this);
				}
				return _commandLists;
			}
			set
			{
				if (_commandLists == value)
				{
					return;
				}
				_commandLists = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effects")] 
		public CArray<CEnum<ProgramEffect>> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<CEnum<ProgramEffect>>) CR2WTypeManager.Create("array:ProgramEffect", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ProgramType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ProgramType>) CR2WTypeManager.Create("ProgramType", "type", cr2w, this);
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

		[Ordinal(4)] 
		[RED("localizationKey")] 
		public CString LocalizationKey
		{
			get
			{
				if (_localizationKey == null)
				{
					_localizationKey = (CString) CR2WTypeManager.Create("String", "localizationKey", cr2w, this);
				}
				return _localizationKey;
			}
			set
			{
				if (_localizationKey == value)
				{
					return;
				}
				_localizationKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startAsUnknown")] 
		public CBool StartAsUnknown
		{
			get
			{
				if (_startAsUnknown == null)
				{
					_startAsUnknown = (CBool) CR2WTypeManager.Create("Bool", "startAsUnknown", cr2w, this);
				}
				return _startAsUnknown;
			}
			set
			{
				if (_startAsUnknown == value)
				{
					return;
				}
				_startAsUnknown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("wasCompleted")] 
		public CBool WasCompleted
		{
			get
			{
				if (_wasCompleted == null)
				{
					_wasCompleted = (CBool) CR2WTypeManager.Create("Bool", "wasCompleted", cr2w, this);
				}
				return _wasCompleted;
			}
			set
			{
				if (_wasCompleted == value)
				{
					return;
				}
				_wasCompleted = value;
				PropertySet(this);
			}
		}

		public ProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
