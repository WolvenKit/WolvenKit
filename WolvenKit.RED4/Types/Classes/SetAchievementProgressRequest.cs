using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAchievementProgressRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetPropertyValue<CEnum<gamedataAchievement>>();
			set => SetPropertyValue<CEnum<gamedataAchievement>>(value);
		}

		[Ordinal(2)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SetAchievementProgressRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
