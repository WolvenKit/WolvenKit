using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityTimePeriod : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hour")] 
		public CEnum<communityECommunitySpawnTime> Hour
		{
			get => GetPropertyValue<CEnum<communityECommunitySpawnTime>>();
			set => SetPropertyValue<CEnum<communityECommunitySpawnTime>>(value);
		}

		public communityTimePeriod()
		{
			Hour = Enums.communityECommunitySpawnTime.Day;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
