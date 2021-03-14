using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInteractionSkillCheck : CVariable
	{
		private CBool _isValid;
		private CEnum<EDeviceChallengeSkill> _skillCheck;
		private CString _skillName;
		private CInt32 _requiredSkill;
		private CInt32 _playerSkill;
		private CString _actionDisplayName;
		private CBool _hasAdditionalRequirements;
		private CEnum<ELogicOperator> _additionalReqOperator;
		private CArray<ConditionData> _additionalRequirements;
		private CBool _isPassed;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get
			{
				if (_skillCheck == null)
				{
					_skillCheck = (CEnum<EDeviceChallengeSkill>) CR2WTypeManager.Create("EDeviceChallengeSkill", "skillCheck", cr2w, this);
				}
				return _skillCheck;
			}
			set
			{
				if (_skillCheck == value)
				{
					return;
				}
				_skillCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skillName")] 
		public CString SkillName
		{
			get
			{
				if (_skillName == null)
				{
					_skillName = (CString) CR2WTypeManager.Create("String", "skillName", cr2w, this);
				}
				return _skillName;
			}
			set
			{
				if (_skillName == value)
				{
					return;
				}
				_skillName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("requiredSkill")] 
		public CInt32 RequiredSkill
		{
			get
			{
				if (_requiredSkill == null)
				{
					_requiredSkill = (CInt32) CR2WTypeManager.Create("Int32", "requiredSkill", cr2w, this);
				}
				return _requiredSkill;
			}
			set
			{
				if (_requiredSkill == value)
				{
					return;
				}
				_requiredSkill = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerSkill")] 
		public CInt32 PlayerSkill
		{
			get
			{
				if (_playerSkill == null)
				{
					_playerSkill = (CInt32) CR2WTypeManager.Create("Int32", "playerSkill", cr2w, this);
				}
				return _playerSkill;
			}
			set
			{
				if (_playerSkill == value)
				{
					return;
				}
				_playerSkill = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("actionDisplayName")] 
		public CString ActionDisplayName
		{
			get
			{
				if (_actionDisplayName == null)
				{
					_actionDisplayName = (CString) CR2WTypeManager.Create("String", "actionDisplayName", cr2w, this);
				}
				return _actionDisplayName;
			}
			set
			{
				if (_actionDisplayName == value)
				{
					return;
				}
				_actionDisplayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hasAdditionalRequirements")] 
		public CBool HasAdditionalRequirements
		{
			get
			{
				if (_hasAdditionalRequirements == null)
				{
					_hasAdditionalRequirements = (CBool) CR2WTypeManager.Create("Bool", "hasAdditionalRequirements", cr2w, this);
				}
				return _hasAdditionalRequirements;
			}
			set
			{
				if (_hasAdditionalRequirements == value)
				{
					return;
				}
				_hasAdditionalRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("additionalReqOperator")] 
		public CEnum<ELogicOperator> AdditionalReqOperator
		{
			get
			{
				if (_additionalReqOperator == null)
				{
					_additionalReqOperator = (CEnum<ELogicOperator>) CR2WTypeManager.Create("ELogicOperator", "additionalReqOperator", cr2w, this);
				}
				return _additionalReqOperator;
			}
			set
			{
				if (_additionalReqOperator == value)
				{
					return;
				}
				_additionalReqOperator = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("additionalRequirements")] 
		public CArray<ConditionData> AdditionalRequirements
		{
			get
			{
				if (_additionalRequirements == null)
				{
					_additionalRequirements = (CArray<ConditionData>) CR2WTypeManager.Create("array:ConditionData", "additionalRequirements", cr2w, this);
				}
				return _additionalRequirements;
			}
			set
			{
				if (_additionalRequirements == value)
				{
					return;
				}
				_additionalRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isPassed")] 
		public CBool IsPassed
		{
			get
			{
				if (_isPassed == null)
				{
					_isPassed = (CBool) CR2WTypeManager.Create("Bool", "isPassed", cr2w, this);
				}
				return _isPassed;
			}
			set
			{
				if (_isPassed == value)
				{
					return;
				}
				_isPassed = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public UIInteractionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
