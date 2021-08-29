using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddAchievementRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataAchievement> _achievement;
		private CWeakHandle<gamedataAchievement_Record> _achievementRecord;

		[Ordinal(1)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		[Ordinal(2)] 
		[RED("achievementRecord")] 
		public CWeakHandle<gamedataAchievement_Record> AchievementRecord
		{
			get => GetProperty(ref _achievementRecord);
			set => SetProperty(ref _achievementRecord, value);
		}
	}
}
