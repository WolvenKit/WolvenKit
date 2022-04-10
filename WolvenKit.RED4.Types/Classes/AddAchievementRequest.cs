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

		[Ordinal(2)] 
		[RED("achievementRecord")] 
		public CWeakHandle<gamedataAchievement_Record> AchievementRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAchievement_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAchievement_Record>>(value);
		}

		public AddAchievementRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
