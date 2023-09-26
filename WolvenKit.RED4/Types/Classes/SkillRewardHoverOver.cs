using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SkillRewardHoverOver : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CWeakHandle<LevelRewardDisplayData> Data
		{
			get => GetPropertyValue<CWeakHandle<LevelRewardDisplayData>>();
			set => SetPropertyValue<CWeakHandle<LevelRewardDisplayData>>(value);
		}

		[Ordinal(1)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public SkillRewardHoverOver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
