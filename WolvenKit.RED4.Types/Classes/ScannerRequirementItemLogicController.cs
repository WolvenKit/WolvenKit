using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerRequirementItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("requirementNameText")] 
		public inkTextWidgetReference RequirementNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("requirementLevelText")] 
		public inkTextWidgetReference RequirementLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("requirementIcon")] 
		public inkImageWidgetReference RequirementIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(5)] 
		[RED("requirementUserData")] 
		public CHandle<RequirementUserData> RequirementUserData
		{
			get => GetPropertyValue<CHandle<RequirementUserData>>();
			set => SetPropertyValue<CHandle<RequirementUserData>>(value);
		}

		public ScannerRequirementItemLogicController()
		{
			RequirementNameText = new();
			RequirementLevelText = new();
			RequirementIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
