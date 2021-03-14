using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasePerkDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CName _name;
		private CString _localizedName;
		private CString _localizedDescription;
		private CName _iconID;
		private redResourceReferenceScriptToken _binkRef;
		private CInt32 _level;
		private CInt32 _maxLevel;
		private CBool _locked;
		private CEnum<gamedataProficiencyType> _proficiency;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get
			{
				if (_attributeId == null)
				{
					_attributeId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attributeId", cr2w, this);
				}
				return _attributeId;
			}
			set
			{
				if (_attributeId == value)
				{
					return;
				}
				_attributeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
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

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get
			{
				if (_localizedDescription == null)
				{
					_localizedDescription = (CString) CR2WTypeManager.Create("String", "localizedDescription", cr2w, this);
				}
				return _localizedDescription;
			}
			set
			{
				if (_localizedDescription == value)
				{
					return;
				}
				_localizedDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconID")] 
		public CName IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (CName) CR2WTypeManager.Create("CName", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("binkRef")] 
		public redResourceReferenceScriptToken BinkRef
		{
			get
			{
				if (_binkRef == null)
				{
					_binkRef = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "binkRef", cr2w, this);
				}
				return _binkRef;
			}
			set
			{
				if (_binkRef == value)
				{
					return;
				}
				_binkRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get
			{
				if (_maxLevel == null)
				{
					_maxLevel = (CInt32) CR2WTypeManager.Create("Int32", "maxLevel", cr2w, this);
				}
				return _maxLevel;
			}
			set
			{
				if (_maxLevel == value)
				{
					return;
				}
				_maxLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("locked")] 
		public CBool Locked
		{
			get
			{
				if (_locked == null)
				{
					_locked = (CBool) CR2WTypeManager.Create("Bool", "locked", cr2w, this);
				}
				return _locked;
			}
			set
			{
				if (_locked == value)
				{
					return;
				}
				_locked = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get
			{
				if (_proficiency == null)
				{
					_proficiency = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiency", cr2w, this);
				}
				return _proficiency;
			}
			set
			{
				if (_proficiency == value)
				{
					return;
				}
				_proficiency = value;
				PropertySet(this);
			}
		}

		public BasePerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
