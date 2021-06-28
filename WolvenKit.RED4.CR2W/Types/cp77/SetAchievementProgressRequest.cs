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
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		[Ordinal(2)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(3)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		public SetAchievementProgressRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
