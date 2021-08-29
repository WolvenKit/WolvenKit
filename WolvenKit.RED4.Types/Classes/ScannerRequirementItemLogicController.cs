using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerRequirementItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _requirementNameText;
		private inkTextWidgetReference _requirementLevelText;
		private inkImageWidgetReference _requirementIcon;
		private CEnum<EDeviceChallengeSkill> _skillCheck;
		private CHandle<RequirementUserData> _requirementUserData;

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
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		[Ordinal(5)] 
		[RED("requirementUserData")] 
		public CHandle<RequirementUserData> RequirementUserData
		{
			get => GetProperty(ref _requirementUserData);
			set => SetProperty(ref _requirementUserData, value);
		}
	}
}
