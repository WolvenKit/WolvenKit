using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionSkillCheck : ActionBool
	{
		private CHandle<SkillCheckBase> _skillCheck;
		private CEnum<EDeviceChallengeSkill> _skillCheckName;
		private CString _localizedName;
		private UIInteractionSkillCheck _skillcheckDescription;
		private CBool _wasPassed;
		private CBool _availableUnpowered;

		[Ordinal(25)] 
		[RED("skillCheck")] 
		public CHandle<SkillCheckBase> SkillCheck
		{
			get
			{
				if (_skillCheck == null)
				{
					_skillCheck = (CHandle<SkillCheckBase>) CR2WTypeManager.Create("handle:SkillCheckBase", "skillCheck", cr2w, this);
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

		[Ordinal(26)] 
		[RED("skillCheckName")] 
		public CEnum<EDeviceChallengeSkill> SkillCheckName
		{
			get
			{
				if (_skillCheckName == null)
				{
					_skillCheckName = (CEnum<EDeviceChallengeSkill>) CR2WTypeManager.Create("EDeviceChallengeSkill", "skillCheckName", cr2w, this);
				}
				return _skillCheckName;
			}
			set
			{
				if (_skillCheckName == value)
				{
					return;
				}
				_skillCheckName = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		[Ordinal(28)] 
		[RED("skillcheckDescription")] 
		public UIInteractionSkillCheck SkillcheckDescription
		{
			get
			{
				if (_skillcheckDescription == null)
				{
					_skillcheckDescription = (UIInteractionSkillCheck) CR2WTypeManager.Create("UIInteractionSkillCheck", "skillcheckDescription", cr2w, this);
				}
				return _skillcheckDescription;
			}
			set
			{
				if (_skillcheckDescription == value)
				{
					return;
				}
				_skillcheckDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get
			{
				if (_wasPassed == null)
				{
					_wasPassed = (CBool) CR2WTypeManager.Create("Bool", "wasPassed", cr2w, this);
				}
				return _wasPassed;
			}
			set
			{
				if (_wasPassed == value)
				{
					return;
				}
				_wasPassed = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("availableUnpowered")] 
		public CBool AvailableUnpowered
		{
			get
			{
				if (_availableUnpowered == null)
				{
					_availableUnpowered = (CBool) CR2WTypeManager.Create("Bool", "availableUnpowered", cr2w, this);
				}
				return _availableUnpowered;
			}
			set
			{
				if (_availableUnpowered == value)
				{
					return;
				}
				_availableUnpowered = value;
				PropertySet(this);
			}
		}

		public ActionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
