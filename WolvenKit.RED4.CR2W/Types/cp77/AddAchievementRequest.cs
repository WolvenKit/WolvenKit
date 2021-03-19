using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddAchievementRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataAchievement> _achievement;
		private wCHandle<gamedataAchievement_Record> _achievementRecord;

		[Ordinal(1)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		[Ordinal(2)] 
		[RED("achievementRecord")] 
		public wCHandle<gamedataAchievement_Record> AchievementRecord
		{
			get => GetProperty(ref _achievementRecord);
			set => SetProperty(ref _achievementRecord, value);
		}

		public AddAchievementRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
