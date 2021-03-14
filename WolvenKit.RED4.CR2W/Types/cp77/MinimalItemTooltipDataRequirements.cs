using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipDataRequirements : IScriptable
	{
		private CBool _isLevelRequirementNotMet;
		private CBool _isSmartlinkRequirementNotMet;
		private CBool _isStrengthRequirementNotMet;
		private CBool _isReflexRequirementNotMet;
		private CBool _isAnyStatRequirementNotMet;
		private CString _strengthOrReflexStatName;
		private CString _anyStatName;
		private CString _anyStatColor;
		private CString _anyStatLocKey;
		private CInt32 _strengthOrReflexValue;
		private CInt32 _anyStatValue;
		private CInt32 _requiredLevel;

		[Ordinal(0)] 
		[RED("isLevelRequirementNotMet")] 
		public CBool IsLevelRequirementNotMet
		{
			get
			{
				if (_isLevelRequirementNotMet == null)
				{
					_isLevelRequirementNotMet = (CBool) CR2WTypeManager.Create("Bool", "isLevelRequirementNotMet", cr2w, this);
				}
				return _isLevelRequirementNotMet;
			}
			set
			{
				if (_isLevelRequirementNotMet == value)
				{
					return;
				}
				_isLevelRequirementNotMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isSmartlinkRequirementNotMet")] 
		public CBool IsSmartlinkRequirementNotMet
		{
			get
			{
				if (_isSmartlinkRequirementNotMet == null)
				{
					_isSmartlinkRequirementNotMet = (CBool) CR2WTypeManager.Create("Bool", "isSmartlinkRequirementNotMet", cr2w, this);
				}
				return _isSmartlinkRequirementNotMet;
			}
			set
			{
				if (_isSmartlinkRequirementNotMet == value)
				{
					return;
				}
				_isSmartlinkRequirementNotMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isStrengthRequirementNotMet")] 
		public CBool IsStrengthRequirementNotMet
		{
			get
			{
				if (_isStrengthRequirementNotMet == null)
				{
					_isStrengthRequirementNotMet = (CBool) CR2WTypeManager.Create("Bool", "isStrengthRequirementNotMet", cr2w, this);
				}
				return _isStrengthRequirementNotMet;
			}
			set
			{
				if (_isStrengthRequirementNotMet == value)
				{
					return;
				}
				_isStrengthRequirementNotMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isReflexRequirementNotMet")] 
		public CBool IsReflexRequirementNotMet
		{
			get
			{
				if (_isReflexRequirementNotMet == null)
				{
					_isReflexRequirementNotMet = (CBool) CR2WTypeManager.Create("Bool", "isReflexRequirementNotMet", cr2w, this);
				}
				return _isReflexRequirementNotMet;
			}
			set
			{
				if (_isReflexRequirementNotMet == value)
				{
					return;
				}
				_isReflexRequirementNotMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isAnyStatRequirementNotMet")] 
		public CBool IsAnyStatRequirementNotMet
		{
			get
			{
				if (_isAnyStatRequirementNotMet == null)
				{
					_isAnyStatRequirementNotMet = (CBool) CR2WTypeManager.Create("Bool", "isAnyStatRequirementNotMet", cr2w, this);
				}
				return _isAnyStatRequirementNotMet;
			}
			set
			{
				if (_isAnyStatRequirementNotMet == value)
				{
					return;
				}
				_isAnyStatRequirementNotMet = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("strengthOrReflexStatName")] 
		public CString StrengthOrReflexStatName
		{
			get
			{
				if (_strengthOrReflexStatName == null)
				{
					_strengthOrReflexStatName = (CString) CR2WTypeManager.Create("String", "strengthOrReflexStatName", cr2w, this);
				}
				return _strengthOrReflexStatName;
			}
			set
			{
				if (_strengthOrReflexStatName == value)
				{
					return;
				}
				_strengthOrReflexStatName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("anyStatName")] 
		public CString AnyStatName
		{
			get
			{
				if (_anyStatName == null)
				{
					_anyStatName = (CString) CR2WTypeManager.Create("String", "anyStatName", cr2w, this);
				}
				return _anyStatName;
			}
			set
			{
				if (_anyStatName == value)
				{
					return;
				}
				_anyStatName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("anyStatColor")] 
		public CString AnyStatColor
		{
			get
			{
				if (_anyStatColor == null)
				{
					_anyStatColor = (CString) CR2WTypeManager.Create("String", "anyStatColor", cr2w, this);
				}
				return _anyStatColor;
			}
			set
			{
				if (_anyStatColor == value)
				{
					return;
				}
				_anyStatColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("anyStatLocKey")] 
		public CString AnyStatLocKey
		{
			get
			{
				if (_anyStatLocKey == null)
				{
					_anyStatLocKey = (CString) CR2WTypeManager.Create("String", "anyStatLocKey", cr2w, this);
				}
				return _anyStatLocKey;
			}
			set
			{
				if (_anyStatLocKey == value)
				{
					return;
				}
				_anyStatLocKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("strengthOrReflexValue")] 
		public CInt32 StrengthOrReflexValue
		{
			get
			{
				if (_strengthOrReflexValue == null)
				{
					_strengthOrReflexValue = (CInt32) CR2WTypeManager.Create("Int32", "strengthOrReflexValue", cr2w, this);
				}
				return _strengthOrReflexValue;
			}
			set
			{
				if (_strengthOrReflexValue == value)
				{
					return;
				}
				_strengthOrReflexValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("anyStatValue")] 
		public CInt32 AnyStatValue
		{
			get
			{
				if (_anyStatValue == null)
				{
					_anyStatValue = (CInt32) CR2WTypeManager.Create("Int32", "anyStatValue", cr2w, this);
				}
				return _anyStatValue;
			}
			set
			{
				if (_anyStatValue == value)
				{
					return;
				}
				_anyStatValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get
			{
				if (_requiredLevel == null)
				{
					_requiredLevel = (CInt32) CR2WTypeManager.Create("Int32", "requiredLevel", cr2w, this);
				}
				return _requiredLevel;
			}
			set
			{
				if (_requiredLevel == value)
				{
					return;
				}
				_requiredLevel = value;
				PropertySet(this);
			}
		}

		public MinimalItemTooltipDataRequirements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
