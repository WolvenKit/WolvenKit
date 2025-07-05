
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankEnemySpawnerData_Record
	{
		[RED("enemyList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EnemyList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("levelList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LevelList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("projectileSpawnerTDBID")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileSpawnerTDBID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("spawnTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
