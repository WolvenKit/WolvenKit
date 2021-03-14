using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SProficiency : CVariable
	{
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _currentLevel;
		private CInt32 _maxLevel;
		private CBool _isAtMaxLevel;
		private CInt32 _currentExp;
		private CInt32 _expToLevel;
		private CInt32 _spentPerkPoints;

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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("isAtMaxLevel")] 
		public CBool IsAtMaxLevel
		{
			get
			{
				if (_isAtMaxLevel == null)
				{
					_isAtMaxLevel = (CBool) CR2WTypeManager.Create("Bool", "isAtMaxLevel", cr2w, this);
				}
				return _isAtMaxLevel;
			}
			set
			{
				if (_isAtMaxLevel == value)
				{
					return;
				}
				_isAtMaxLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentExp")] 
		public CInt32 CurrentExp
		{
			get
			{
				if (_currentExp == null)
				{
					_currentExp = (CInt32) CR2WTypeManager.Create("Int32", "currentExp", cr2w, this);
				}
				return _currentExp;
			}
			set
			{
				if (_currentExp == value)
				{
					return;
				}
				_currentExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("expToLevel")] 
		public CInt32 ExpToLevel
		{
			get
			{
				if (_expToLevel == null)
				{
					_expToLevel = (CInt32) CR2WTypeManager.Create("Int32", "expToLevel", cr2w, this);
				}
				return _expToLevel;
			}
			set
			{
				if (_expToLevel == value)
				{
					return;
				}
				_expToLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("spentPerkPoints")] 
		public CInt32 SpentPerkPoints
		{
			get
			{
				if (_spentPerkPoints == null)
				{
					_spentPerkPoints = (CInt32) CR2WTypeManager.Create("Int32", "spentPerkPoints", cr2w, this);
				}
				return _spentPerkPoints;
			}
			set
			{
				if (_spentPerkPoints == value)
				{
					return;
				}
				_spentPerkPoints = value;
				PropertySet(this);
			}
		}

		public SProficiency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
