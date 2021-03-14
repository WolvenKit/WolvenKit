using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyProgressEvent : redEvent
	{
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _expValue;
		private CInt32 _remainingXP;
		private CInt32 _delta;
		private CInt32 _currentLevel;
		private CBool _isLevelMaxed;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("expValue")] 
		public CInt32 ExpValue
		{
			get
			{
				if (_expValue == null)
				{
					_expValue = (CInt32) CR2WTypeManager.Create("Int32", "expValue", cr2w, this);
				}
				return _expValue;
			}
			set
			{
				if (_expValue == value)
				{
					return;
				}
				_expValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("remainingXP")] 
		public CInt32 RemainingXP
		{
			get
			{
				if (_remainingXP == null)
				{
					_remainingXP = (CInt32) CR2WTypeManager.Create("Int32", "remainingXP", cr2w, this);
				}
				return _remainingXP;
			}
			set
			{
				if (_remainingXP == value)
				{
					return;
				}
				_remainingXP = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delta")] 
		public CInt32 Delta
		{
			get
			{
				if (_delta == null)
				{
					_delta = (CInt32) CR2WTypeManager.Create("Int32", "delta", cr2w, this);
				}
				return _delta;
			}
			set
			{
				if (_delta == value)
				{
					return;
				}
				_delta = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get
			{
				if (_currentLevel == null)
				{
					_currentLevel = (CInt32) CR2WTypeManager.Create("Int32", "currentLevel", cr2w, this);
				}
				return _currentLevel;
			}
			set
			{
				if (_currentLevel == value)
				{
					return;
				}
				_currentLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isLevelMaxed")] 
		public CBool IsLevelMaxed
		{
			get
			{
				if (_isLevelMaxed == null)
				{
					_isLevelMaxed = (CBool) CR2WTypeManager.Create("Bool", "isLevelMaxed", cr2w, this);
				}
				return _isLevelMaxed;
			}
			set
			{
				if (_isLevelMaxed == value)
				{
					return;
				}
				_isLevelMaxed = value;
				PropertySet(this);
			}
		}

		public ProficiencyProgressEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
