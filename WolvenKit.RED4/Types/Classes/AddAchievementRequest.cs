using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddAchievementRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetPropertyValue<CEnum<gamedataAchievement>>();
			set => SetPropertyValue<CEnum<gamedataAchievement>>(value);
		}

		public AddAchievementRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
