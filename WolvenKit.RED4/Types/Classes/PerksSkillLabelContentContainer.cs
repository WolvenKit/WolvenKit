using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		[Ordinal(10)] 
		[RED("levelLabel")] 
		public inkTextWidgetReference LevelLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("skillData")] 
		public CHandle<ProficiencyDisplayData> SkillData
		{
			get => GetPropertyValue<CHandle<ProficiencyDisplayData>>();
			set => SetPropertyValue<CHandle<ProficiencyDisplayData>>(value);
		}

		public PerksSkillLabelContentContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
