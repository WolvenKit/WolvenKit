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
			get
			{
				if (_achievement == null)
				{
					_achievement = (CEnum<gamedataAchievement>) CR2WTypeManager.Create("gamedataAchievement", "achievement", cr2w, this);
				}
				return _achievement;
			}
			set
			{
				if (_achievement == value)
				{
					return;
				}
				_achievement = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("achievementRecord")] 
		public wCHandle<gamedataAchievement_Record> AchievementRecord
		{
			get
			{
				if (_achievementRecord == null)
				{
					_achievementRecord = (wCHandle<gamedataAchievement_Record>) CR2WTypeManager.Create("whandle:gamedataAchievement_Record", "achievementRecord", cr2w, this);
				}
				return _achievementRecord;
			}
			set
			{
				if (_achievementRecord == value)
				{
					return;
				}
				_achievementRecord = value;
				PropertySet(this);
			}
		}

		public AddAchievementRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
