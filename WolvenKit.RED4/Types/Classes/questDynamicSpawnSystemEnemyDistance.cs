using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicSpawnSystemEnemyDistance : questIDistance
	{
		[Ordinal(0)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("checkAllEnemies")] 
		public CBool CheckAllEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("distanceType")] 
		public CEnum<questDistanceType> DistanceType
		{
			get => GetPropertyValue<CEnum<questDistanceType>>();
			set => SetPropertyValue<CEnum<questDistanceType>>(value);
		}

		public questDynamicSpawnSystemEnemyDistance()
		{
			CheckAllEnemies = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
