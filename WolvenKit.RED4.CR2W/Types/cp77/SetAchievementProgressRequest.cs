using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAchievementProgressRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataAchievement> _achievement;
		private CInt32 _currentValue;
		private CInt32 _maxValue;

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
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get
			{
				if (_currentValue == null)
				{
					_currentValue = (CInt32) CR2WTypeManager.Create("Int32", "currentValue", cr2w, this);
				}
				return _currentValue;
			}
			set
			{
				if (_currentValue == value)
				{
					return;
				}
				_currentValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CInt32) CR2WTypeManager.Create("Int32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		public SetAchievementProgressRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
