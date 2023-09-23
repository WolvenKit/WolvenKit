using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksSkillLevelLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("levelData")] 
		public CHandle<LevelRewardDisplayData> LevelData
		{
			get => GetPropertyValue<CHandle<LevelRewardDisplayData>>();
			set => SetPropertyValue<CHandle<LevelRewardDisplayData>>(value);
		}

		[Ordinal(3)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewPerksSkillLevelLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
