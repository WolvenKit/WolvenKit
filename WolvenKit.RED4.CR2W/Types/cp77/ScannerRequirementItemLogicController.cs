using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerRequirementItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _requirementNameText;
		private inkTextWidgetReference _requirementLevelText;
		private inkImageWidgetReference _requirementIcon;
		private UIInteractionSkillCheck _requirementStruct;
		private CEnum<EDeviceChallengeSkill> _skillCheck;

		[Ordinal(1)] 
		[RED("requirementNameText")] 
		public inkTextWidgetReference RequirementNameText
		{
			get
			{
				if (_requirementNameText == null)
				{
					_requirementNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requirementNameText", cr2w, this);
				}
				return _requirementNameText;
			}
			set
			{
				if (_requirementNameText == value)
				{
					return;
				}
				_requirementNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requirementLevelText")] 
		public inkTextWidgetReference RequirementLevelText
		{
			get
			{
				if (_requirementLevelText == null)
				{
					_requirementLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requirementLevelText", cr2w, this);
				}
				return _requirementLevelText;
			}
			set
			{
				if (_requirementLevelText == value)
				{
					return;
				}
				_requirementLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("requirementIcon")] 
		public inkImageWidgetReference RequirementIcon
		{
			get
			{
				if (_requirementIcon == null)
				{
					_requirementIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "requirementIcon", cr2w, this);
				}
				return _requirementIcon;
			}
			set
			{
				if (_requirementIcon == value)
				{
					return;
				}
				_requirementIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("requirementStruct")] 
		public UIInteractionSkillCheck RequirementStruct
		{
			get
			{
				if (_requirementStruct == null)
				{
					_requirementStruct = (UIInteractionSkillCheck) CR2WTypeManager.Create("UIInteractionSkillCheck", "requirementStruct", cr2w, this);
				}
				return _requirementStruct;
			}
			set
			{
				if (_requirementStruct == value)
				{
					return;
				}
				_requirementStruct = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		public ScannerRequirementItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
