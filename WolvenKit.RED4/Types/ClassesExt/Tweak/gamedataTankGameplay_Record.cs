
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankGameplay_Record
	{
		[RED("backgroundTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName BackgroundTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("enemySpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName EnemySpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("gameplayData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID GameplayData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("obstacleSpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ObstacleSpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("pickupSpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName PickupSpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("playerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName PlayerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
