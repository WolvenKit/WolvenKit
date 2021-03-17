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
			get => GetProperty(ref _requirementNameText);
			set => SetProperty(ref _requirementNameText, value);
		}

		[Ordinal(2)] 
		[RED("requirementLevelText")] 
		public inkTextWidgetReference RequirementLevelText
		{
			get => GetProperty(ref _requirementLevelText);
			set => SetProperty(ref _requirementLevelText, value);
		}

		[Ordinal(3)] 
		[RED("requirementIcon")] 
		public inkImageWidgetReference RequirementIcon
		{
			get => GetProperty(ref _requirementIcon);
			set => SetProperty(ref _requirementIcon, value);
		}

		[Ordinal(4)] 
		[RED("requirementStruct")] 
		public UIInteractionSkillCheck RequirementStruct
		{
			get => GetProperty(ref _requirementStruct);
			set => SetProperty(ref _requirementStruct, value);
		}

		[Ordinal(5)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		public ScannerRequirementItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
