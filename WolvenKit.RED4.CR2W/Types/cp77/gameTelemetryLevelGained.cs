using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryLevelGained : CVariable
	{
		private wCHandle<gameObject> _playerPuppet;
		private CEnum<gamedataProficiencyType> _proficiencyType;
		private CInt32 _proficiencyValue;
		private CInt32 _perkPointsAwarded;
		private CInt32 _attributePointsAwarded;
		private CBool _isDebugEvt;

		[Ordinal(0)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get
			{
				if (_proficiencyType == null)
				{
					_proficiencyType = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiencyType", cr2w, this);
				}
				return _proficiencyType;
			}
			set
			{
				if (_proficiencyType == value)
				{
					return;
				}
				_proficiencyType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("proficiencyValue")] 
		public CInt32 ProficiencyValue
		{
			get
			{
				if (_proficiencyValue == null)
				{
					_proficiencyValue = (CInt32) CR2WTypeManager.Create("Int32", "proficiencyValue", cr2w, this);
				}
				return _proficiencyValue;
			}
			set
			{
				if (_proficiencyValue == value)
				{
					return;
				}
				_proficiencyValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("perkPointsAwarded")] 
		public CInt32 PerkPointsAwarded
		{
			get
			{
				if (_perkPointsAwarded == null)
				{
					_perkPointsAwarded = (CInt32) CR2WTypeManager.Create("Int32", "perkPointsAwarded", cr2w, this);
				}
				return _perkPointsAwarded;
			}
			set
			{
				if (_perkPointsAwarded == value)
				{
					return;
				}
				_perkPointsAwarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attributePointsAwarded")] 
		public CInt32 AttributePointsAwarded
		{
			get
			{
				if (_attributePointsAwarded == null)
				{
					_attributePointsAwarded = (CInt32) CR2WTypeManager.Create("Int32", "attributePointsAwarded", cr2w, this);
				}
				return _attributePointsAwarded;
			}
			set
			{
				if (_attributePointsAwarded == value)
				{
					return;
				}
				_attributePointsAwarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isDebugEvt")] 
		public CBool IsDebugEvt
		{
			get
			{
				if (_isDebugEvt == null)
				{
					_isDebugEvt = (CBool) CR2WTypeManager.Create("Bool", "isDebugEvt", cr2w, this);
				}
				return _isDebugEvt;
			}
			set
			{
				if (_isDebugEvt == value)
				{
					return;
				}
				_isDebugEvt = value;
				PropertySet(this);
			}
		}

		public gameTelemetryLevelGained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
