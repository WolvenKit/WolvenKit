using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetAchievementProgressRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("customTarget")] 
		public CInt32 CustomTarget
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetPropertyValue<CEnum<gamedataAchievement>>();
			set => SetPropertyValue<CEnum<gamedataAchievement>>(value);
		}

		public questSetAchievementProgressRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
